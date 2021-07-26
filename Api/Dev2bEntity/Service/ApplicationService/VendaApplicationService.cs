using System.Collections.Generic;
using System.Linq;
using Common.Dto;
using Common.Exceptions;
using Domain.Entities;
using Infrasctruture.UnitOfWork.Interfaces;
using Service.ApplicationService.Interfaces;

namespace Service.ApplicationService
{
    public class VendaApplicationService : IVendaApplicationService
    {
        private readonly IVendaUnitOfWork Uow;

        public VendaApplicationService(IVendaUnitOfWork vendaUnitOfWork)
        {
            Uow = vendaUnitOfWork;
        }

        public IEnumerable<VendaGetAllDto> GetAll()
        {
            var vendasAll = Uow.VendaRepository.GetAll();

            var dto = vendasAll.Select(x => new VendaGetAllDto
            {
                Id = x.Id,
                Nome = x.Cliente.Nome,
                Cpf = x.Cliente.Cpf,
                DataVenda = x.Data,
                ValorTotal = x.ListItensVenda.Sum(y => y.ValorTotal),
                Produtos = x.ListItensVenda.Select(y => new ProdutoVendaGetDto{
                    Id = y.Produto.Id,
                    Descricao = y.Produto.Descricao,
                    Preco = y.Produto.Preco,
                    Quantidade = x.ListItensVenda.Select(y => y.Quantidade).FirstOrDefault()
                }).ToList()
            });

            return dto;
        }

        public int Post(VendaPostDto vendaDto)
        {
            var venda = new Venda()
            {
                IdCliente = vendaDto.IdCliente,
                Data = vendaDto.Data,
                ListItensVenda = new List<ItensVenda>()
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



                venda.ListItensVenda.Add(new ItensVenda()
                {
                    IdVenda = venda.Id,
                    IdProduto = productFinded.Id,
                    Quantidade = item.Quantidade,
                    ValorTotal = item.Quantidade * productFinded.Preco
                });
            }
            Uow.VendaRepository.Post(venda);
            Uow.Commit();

            return venda.Id;
        }
    }
}
