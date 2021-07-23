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
        private readonly IUnitOfWork Uow;

        public ProdutoApplicationService(IUnitOfWork produtoUnitOfWork)
        {
            Uow = produtoUnitOfWork;
        }

        public void Delete(int id)
        {
            var deleteProduct = Uow.ProdutoRepository.GetById(id);
            if (deleteProduct == null)
                throw new DomainException("Id não encontrado");

            Uow.ProdutoRepository.Delete(deleteProduct);

            Uow.Commit();
        }

        public IEnumerable<ProdutoGetAllDto> GetAll()
        {
            var dto = Uow.ProdutoRepository.GetAll().Select(p => new ProdutoGetAllDto { 
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
            var productById = Uow.ProdutoRepository.GetById(id);
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

            var products = Uow.ProdutoRepository.GetAll();
            var descriptionRepeat = products.Any(x => x.Descricao == productEntity.Descricao);
            if (descriptionRepeat)
                throw new DomainException($"Não é possível cadastrar Produto repetido");

            Uow.ProdutoRepository.Post(productEntity);

            Uow.Commit();

            return productEntity.Id;
        }

        public void Put(int id, ProdutoPutDto produtoPutDto)
        {
            var productById = Uow.ProdutoRepository.GetById(id);
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

            Uow.ProdutoRepository.Put(productEntity);

            Uow.Commit();
        }
    }
}
