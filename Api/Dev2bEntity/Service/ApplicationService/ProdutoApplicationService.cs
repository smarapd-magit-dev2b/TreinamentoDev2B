using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Common.Dto;
using Common.Exceptions;
using Domain.Entities;
using Infrasctruture.UnitOfWork.Interfaces;
using Service.ApplicationService.Interfaces;

namespace Service.ApplicationService
{
    public class ProdutoApplicationService : IProdutoApplicationService
    {
        private readonly IProdutoUnitOfWork ProdutoUow;

        public ProdutoApplicationService(IProdutoUnitOfWork produtoUnitOfWork)
        {
            ProdutoUow = produtoUnitOfWork;
        }

        public void Delete(int id)
        {
            var deleteProduct = ProdutoUow.ProdutoRepository.GetById(id);
            if (deleteProduct == null)
                throw new DomainException("Id não encontrado");

            ProdutoUow.ProdutoRepository.Delete(deleteProduct);

            ProdutoUow.Commit();
        }

        public IEnumerable<ProdutoGetAllDto> GetAll()
        {
            var dto = ProdutoUow.ProdutoRepository.GetAll().Select(p => new ProdutoGetAllDto { 
                Id = p.Id,
                DataInclusao = p.DataInclusao,
                Descricao = p.Descricao,
                Preco = p.Preco,
                Quantidade = p.Quantidade
            }).ToList();

            return dto;
        }

        public ProdutoGetAllDto GetById(int id)
        {
            var productById = ProdutoUow.ProdutoRepository.GetById(id);
            if (productById == null)
                throw new DomainException("Id não encontrado");

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Produto, ProdutoGetAllDto>().ReverseMap();
            });

            var mapper = new Mapper(config);
            var productEntity = mapper.Map<ProdutoGetAllDto>(productById);

            return productEntity;
        }

        public int Post(ProdutoPostDto produtoPostDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Produto, ProdutoPostDto>().ReverseMap();
            });

            var mapper = config.CreateMapper();
            var productEntity = mapper.Map<Produto>(produtoPostDto);

            if (productEntity.Preco < 0)
                throw new DomainException("Não é permitido preço com valor negativo");

            var products = ProdutoUow.ProdutoRepository.GetAll();
            var descriptionRepeat = products.Any(x => (x.Descricao == productEntity.Descricao) &&
                x.Id != productEntity.Id);
            if (descriptionRepeat)
                throw new DomainException($"Não é possível cadastrar Produto repetido");

            ProdutoUow.ProdutoRepository.Post(productEntity);

            ProdutoUow.Commit();

            return productEntity.Id;
        }

        public void Put(int id, ProdutoPutDto produtoPutDto)
        {
            var productById = ProdutoUow.ProdutoRepository.GetById(id);
            if(productById == null)
                throw new DomainException($"Id não encontrado");

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Produto, ProdutoPutDto>().ReverseMap();
            });

            var mapper = config.CreateMapper();
            var productEntity = mapper.Map<Produto>(produtoPutDto);

            productEntity.Id = productById.Id;

            if (productEntity.Preco < 0)
                throw new DomainException("Não é permitido preço com valor negativo");

            ProdutoUow.ProdutoRepository.Put(productEntity);

            ProdutoUow.Commit();
        }
    }
}
