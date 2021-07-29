using AutoMapper;
using Commom.Dto.Product;
using Commom.Exceptions;
using Domain;
using Infrastructure.UnitOfWork.Interfaces;
using Service.AplicationService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service.AplicationService
{
    public class ProductAplicationService : IProductAplicationService
    {
        private static readonly MapperConfiguration _config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Product, ProductGetDto>();
            cfg.CreateMap<ProductGetDto, Product>();
            cfg.CreateMap<ProductPostDto, Product>();
            cfg.CreateMap<Product, ProductPostDto>();
        });
        private static readonly IMapper _mapper = new Mapper(_config);
        private readonly IProductUnitOfWork _uow;

        public ProductAplicationService(IProductUnitOfWork uow) => _uow = uow;

        #region Get
        public IEnumerable<ProductGetDto> Get()
        {
            IQueryable<Product> products = _uow.ProductRepository.Get();

            ProductsValidate(products);

            return ProductToProductGetDtos(products);
        }

        public ProductGetDto Get(int id)
        {
            Product product = _uow.ProductRepository.Get(id);

            IdValidate(id, product);

            return _mapper.Map<ProductGetDto>(product);
        }
        #endregion

        #region Post
        public int Post(ProductPostDto dto)
        {
            PostValidate(_uow.ProductRepository.Get(), dto);

            Product product = _mapper.Map<Product>(dto);

            product.InclusionDate = DateTime.Now;

            _uow.ProductRepository.Post(product);

            _uow.Commit();

            return product.Id;
        }
        #endregion

        #region Put
        public void Put(int id, ProductPostDto dto)
        {
            Product oldProduct = _uow.ProductRepository.Get(id);

            PutValidate(_uow.ProductRepository.Get(), oldProduct, dto, id);

            Product product = _mapper.Map<Product>(dto);

            product.Id = id;
            product.InclusionDate = oldProduct.InclusionDate;

            _uow.ProductRepository.Put(product);

            _uow.Commit();
        }
        #endregion

        #region Delete
        public void Delete(int id)
        {
            Product product = _uow.ProductRepository.Get(id);

            IdValidate(id, product);

            _uow.ProductRepository.Delete(product);

            _uow.Commit();
        }
        #endregion

        #region Parses
        private IEnumerable<ProductGetDto> ProductToProductGetDtos(IQueryable<Product> products) =>
            from Product p in products
            let dto = new ProductGetDto()
            {
                Id = p.Id,
                Description = p.Description,
                InclusionDate = p.InclusionDate,
                Price = p.Price,
                Amount = p.Amount
            }
            select dto;
        #endregion

        #region Validate
        private void ProductsValidate(IQueryable<Product> products)
        {
            if (!products.Any())
                throw new DomainException("There are no registered products");
        }

        private void IdValidate(int id, Product product)
        {
            if (product == null)
                throw new DomainException($"There is no product with id {id}");
        }

        private void PostValidate(IQueryable<Product> products, ProductPostDto dto)
        {
            Validate(dto);

            DescriptionExists(products, dto);
        }

        private void PutValidate(IQueryable<Product> products,
                                 Product oldProduct,
                                 ProductPostDto dto,
                                 int id)
        {
            IdValidate(id, oldProduct);

            Validate(dto);

            if (oldProduct.Description.ToLower() != dto.Description.ToLower())
                DescriptionExists(products, dto);
        }

        private void Validate(ProductPostDto dto)
        {
            DescriptionValidate(dto.Description);

            PriceValidate(dto.Price);

            AmountValidate(dto.Amount);
        }
        #endregion

        #region Properties
        private void DescriptionValidate(string description)
        {
            if (string.IsNullOrEmpty(description))
                throw new DomainException("Description is mandatory");
        }

        private void DescriptionExists(IQueryable<Product> products, ProductPostDto dto)
        {
            bool exist = products.Any(p => p.Description == dto.Description);

            if (exist)
                throw new DomainException("Product already registered");
        }

        private void PriceValidate(decimal price)
        {
            if (price < 0)
                throw new DomainException("Price cannot be negative");
        }

        private void AmountValidate(int amount)
        {
            if (amount < 0)
                throw new DomainException("Amount cannot be negative");
        }
        #endregion
    }
}
