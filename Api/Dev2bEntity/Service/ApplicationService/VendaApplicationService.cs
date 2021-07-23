using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Common.Dto;
using Common.Exceptions;
using Domain.Entities;
using Infrasctruture.UnitOfWork.Interfaces;
using Service.ApplicationService.Interfaces;

namespace Service.ApplicationService
{
    public class VendaApplicationService : IVendaApplicationService
    {
        private readonly IUnitOfWork Uow;

        public VendaApplicationService(IUnitOfWork vendaUnitOfWork)
        {
            Uow = vendaUnitOfWork;
        }

        public IEnumerable<VendaGetAllDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public VendaGetAllDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Post(VendaPostDto vendaDto)
        {
            var venda = new Venda()
            {
                IdCliente = vendaDto.IdCliente,
                Data = vendaDto.Data,
                ItensVenda = new List<ItensVenda>()
            };

            var products = Uow.ProdutoRepository.GetAll();
            foreach (var item in vendaDto.Produtos)
            {
                var productsId = products.Any(x => x.Id == item.Id);
                if (!productsId)
                    throw new DomainException($"Produto não existe");
                var productFinded = products.FirstOrDefault(x => x.Id == item.Id);
                if (item.Quantidade > productFinded.Quantidade)
                    throw new DomainException($"Quantidade superior ao estoque de produto");

                
                productFinded.Quantidade -= item.Quantidade;
                Uow.ProdutoRepository.Put(productFinded);

                venda.ItensVenda.Add(new ItensVenda()
                {
                    IdVenda = venda.Id,
                    IdProduto = productFinded.Id,
                    Quantidade = item.Quantidade,
                    ValorTotal = item.Quantidade * productFinded.Preco
                });
            }
            //var vendaCheck = venda.ItensVenda.Select(x => x.IdProduto).FirstOrDefault();

            //var productsExists = products.Any(x => x.Id == vendaCheck);
            //if (!productsExists)
            //    throw new DomainException($"Produto não existe");

            //item.Quantidade = venda.ItensVenda.Select(x => x.Quantidade).FirstOrDefault();
            Uow.VendaRepository.Post(venda);
            Uow.Commit();

            return venda.Id;
        }
    }
}
