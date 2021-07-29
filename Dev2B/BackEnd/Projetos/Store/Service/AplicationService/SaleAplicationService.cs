using Commom.Dto.Sale;
using Commom.Dto.SaleItem;
using Commom.Exceptions;
using Domain;
using Infrastructure.UnitOfWork.Interfaces;
using Service.AplicationService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service.AplicationService
{
    public class SaleAplicationService : ISaleAplicationService
    {
        private readonly ISaleUnitOfWork _uow;

        public SaleAplicationService(ISaleUnitOfWork uow) => _uow = uow;

        #region Get
        public IEnumerable<SaleGetDto> Get()
        {
            IQueryable<Sale> sales = _uow.SaleRepository.Get();

            GetValidate(sales);

            return SalesToSaleGetDtos(sales);
        }
        #endregion

        #region Post
        public int Post(int customerId, IEnumerable<SaleItemPostDto> dtos)
        {
            SalePostValidate(customerId, dtos);

            Sale sale = new Sale()
            {
                CustomerId = customerId,
                Date = DateTime.Now
            };

            List<SaleItem> items = new List<SaleItem>();

            foreach (SaleItemPostDto dtoItem in dtos)
            {
                Product product = _uow.ProductRepository.Get(dtoItem.ProductId);

                SaleItemPostValidate(product, dtoItem);

                product.Amount -= dtoItem.Amount;

                _uow.ProductRepository.Put(product);

                SaleItem item = new SaleItem()
                {
                    ProductId = dtoItem.ProductId,
                    Price = product.Price,
                    Amount = dtoItem.Amount
                };

                items.Add(item);
            }
            sale.Items = items;

            _uow.SaleRepository.Post(sale);

            _uow.Commit();

            return sale.Id;
        }
        #endregion

        #region Parses
        private IEnumerable<SaleGetDto> SalesToSaleGetDtos(IQueryable<Sale> sales) =>
            sales.Select(s => new SaleGetDto()
            {
                Customer = s.Customer.Name,
                Cpf = s.Customer.Cpf,
                Date = s.Date,
                Total = s.Items.Sum(i => i.Price * i.Amount),
                Items = s.Items.Select(i => new SaleItemGetDto()
                {
                    Product = s.Products.First(p => p.Id == i.ProductId).Description,
                    Price = i.Price,
                    Amount = i.Amount
                })
            });
        #endregion

        #region Validate
        private void GetValidate(IQueryable<Sale> sales)
        {
            if (!sales.Any())
                throw new DomainException("There are no registered sales");
        }

        private void SalePostValidate(int customerId, IEnumerable<SaleItemPostDto> dtos)
        {
            Customer customer = _uow.CustomerRepository.Get(customerId);

            CustomerIdValidate(customer, customerId);

            ProductsIdRepeat(dtos);
        }

        private void SaleItemPostValidate(Product product, SaleItemPostDto dto)
        {
            ProductIdValidate(product, dto.ProductId);

            AmountValidate(product, dto.Amount);
        }

        private void CustomerIdValidate(Customer customer, int id)
        {
            if (customer == null)
                throw new DomainException($"There is no customer with id {id}");
        }

        private void ProductsIdRepeat(IEnumerable<SaleItemPostDto> items)
        {
            bool repeatProducts = items.GroupBy(i => i.ProductId)
                                       .Any(i => i.Count() > 1);

            if (repeatProducts)
                throw new DomainException("You added more than one item with the same id");
        }

        private void ProductIdValidate(Product product, int id)
        {
            if (product == null)
                throw new DomainException($"There is no product with id {id}");
        }
        #endregion

        #region Properties
        private void AmountValidate(Product product, int amount)
        {
            if (amount < 1)
                throw new DomainException($"{product.Description} quantity must be greater than 0");

            if (amount > product.Amount)
                throw new DomainException($"Quantity of {product.Description} out of stock");
        }
        #endregion
    }
}
