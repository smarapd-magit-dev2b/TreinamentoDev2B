using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Common.Dto;
using Common.Exceptions;
using Common.Helpers;
using Domain.Entities;
using Infrasctruture.UnitOfWork.Interfaces;
using Service.ApplicationService.Interfaces;

namespace Service.ApplicationService
{
    public class ClienteApplicationService : IClienteApplicationService
    {
        private readonly IClienteUnitOfWork ClienteUow;

        public ClienteApplicationService(IClienteUnitOfWork clienteUnitOfWork)
        {
            ClienteUow = clienteUnitOfWork;
        }

        public void Delete(int id)
        {
            var deleteClient = ClienteUow.ClienteRepository.GetById(id);
            if (deleteClient == null)
                throw new DomainException("Id não encontrado");

            ClienteUow.ClienteRepository.Delete(deleteClient);

            ClienteUow.Commit();
        }

        public IEnumerable<ClienteGetAllDto> GetAll()
        {
            var dto = ClienteUow.ClienteRepository.GetAll().Select(c => new ClienteGetAllDto
            {
                Id = c.Id,
                Nome = c.Nome,
                DataNascimento = c.DataNascimento,
                Telefone = c.Telefone,
                Cpf = c.Cpf,
                Rg = c.Rg,
                Sexo = c.Sexo
            }).ToList();

            return dto;
        }

        public ClienteGetAllDto GetById(int id)
        {
            var clienteGetById = ClienteUow.ClienteRepository.GetById(id);
            if (clienteGetById == null)
                throw new DomainException("Id não encontrado");

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Cliente, ClienteGetAllDto>().ReverseMap();
            });

            var mapper = new Mapper(config);
            var clienteEntity = mapper.Map<ClienteGetAllDto>(clienteGetById);

            return clienteEntity;
        }

        public int Post(ClientePostDto clientePostDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Cliente, ClientePostDto>().ReverseMap();
            });

            var mapper = config.CreateMapper();
            var clienteEntity = mapper.Map<Cliente>(clientePostDto);

            Validate(clienteEntity);

            ClienteUow.ClienteRepository.Post(clienteEntity);

            ClienteUow.Commit();

            return clienteEntity.Id;
        }

        private void Validate(Cliente clienteEntity)
        {
            if (string.IsNullOrEmpty(clienteEntity.Nome))
                throw new DomainException($"O campo Nome é obrigatório");
            if (clienteEntity.Nome.Length < 5)
                throw new DomainException($"O campo Nome deve ter no mínimo 5 letras");
            if (CpfHelper.IsCpf(clienteEntity.Cpf) == false)
                throw new DomainException($"Cpf inválido");
            var clients = ClienteUow.ClienteRepository.GetAll();
            var clientRepeat = clients.Any(x => (x.Nome.ToLower() == clienteEntity.Nome.ToLower() || 
                CpfHelper.FormatCpf(x.Cpf) == CpfHelper.FormatCpf(clienteEntity.Cpf)) && x.Id != clienteEntity.Id);
            if (clientRepeat)
                throw new DomainException($"Não é possível cadastrar Nome ou Cpf repetido");
        }

        public void Put(int id, ClientePutDto clientePutDto)
        {
            var clienteById = ClienteUow.ClienteRepository.GetById(id);
            if (clienteById == null)
                throw new DomainException($"Id não encontrado");

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Cliente, ClientePutDto>().ReverseMap();
            });

            var mapper = config.CreateMapper();
            var clienteEntity = mapper.Map<Cliente>(clientePutDto);

            clienteEntity.Id = clienteById.Id;

            Validate(clienteEntity);

            ClienteUow.ClienteRepository.Put(clienteEntity);

            ClienteUow.Commit();
        }
    }
}
