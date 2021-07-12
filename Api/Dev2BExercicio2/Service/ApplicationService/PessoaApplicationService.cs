using System.Collections.Generic;
using System.Linq;
using Common.Dto;
using Common.Exceptions;
using Common.Entities;
using Infrastructure.UnitOfWork.Interfaces;
using Service.ApplicationService.Interfaces;
using Common.Helpers;
using AutoMapper;

namespace Service.ApplicationService
{
    public class PessoaApplicationService : IPessoaApplicationService
    {
        private readonly IPessoaUnitOfWork Uow;
        public PessoaApplicationService(IPessoaUnitOfWork pessoaUnitOfWork)
        {
            Uow = pessoaUnitOfWork;
        }

        public int AddPessoa(PessoaPostDto dto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PessoaPostDto, Pessoa>().ReverseMap();
            });

            var mapper = new Mapper(config);
            var pessoaEntity = mapper.Map<Pessoa>(dto);
            pessoaEntity.Id = Uow.PessoaRepository.GetNextId();
            pessoaEntity.UsuarioAtivo = true;

            Validate(pessoaEntity);

            Uow.PessoaRepository.Add(pessoaEntity);

            return pessoaEntity.Id;
        }

        public void EditPessoa(int id, PessoaPutDto putDto)
        {
            //usar auto mapper
            if (Uow.PessoaRepository.GetPessoaById(id) == null)
                throw new DomainException($"Id não encontrado");

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PessoaPutDto, Pessoa>().ReverseMap();
            });

            var mapper = new Mapper(config);
            var pessoaEntity = mapper.Map<Pessoa>(putDto);

            Validate(pessoaEntity);

            Uow.PessoaRepository.Edit(id, pessoaEntity);
        }

        private void Validate(Pessoa pessoa)
        {
            if (DateTimeHelper.GetIdade(pessoa.DataNascimento) < 18)
                throw new DomainException($"Cadastro válido apenas para pessoas maiores de 18 anos");
            if (string.IsNullOrEmpty(pessoa.Nome))
                throw new DomainException($"O campo Nome é obrigatório");
            if (string.IsNullOrEmpty(pessoa.SobreNome))
                throw new DomainException($"O campo SobreNome é obrigatório");
            if (string.IsNullOrEmpty(pessoa.Cpf))
                throw new DomainException($"O campo Cpf é obrigatório");
            if (pessoa.Nome.Length < 5)
                throw new DomainException($"O campo Nome deve ter no mínimo 5 letras");
            if (CpfHelper.IsCpf(pessoa.Cpf) != true)
                throw new DomainException($"Permitido apenas Cpf válido");
        }

        public List<PessoaGetAllDto> GetAll()
        {
            var dto = Uow.PessoaRepository.GetAll().Select(p => new PessoaGetAllDto
            {
                Id = p.Id,
                Nome = p.Nome,
                SobreNome = p.SobreNome,
                DataNascimento = p.DataNascimento,
                Altura = p.Altura,
                Peso = p.Peso,
                Raca = p.Raca,
                Idade = DateTimeHelper.GetIdade(p.DataNascimento),
                UsuarioAtivo = p.UsuarioAtivo,  
                Cpf = p.Cpf,
                Filhos = p.Filhos
            }).ToList();

            return dto;
        }

        public void DeletePessoa(int id)
        {
            var deletePessoa = Uow.PessoaRepository.GetPessoaById(id);
            if (deletePessoa == null)
                throw new DomainException($"Id não encontrado");
            if (deletePessoa.UsuarioAtivo == true)
                throw new DomainException($"Não é possível deletar usuário Ativo");
            Uow.PessoaRepository.Delete(deletePessoa);
        }

        public PessoaGetAllDto GetPessoaId(int id)
        {
            var pessoaGetId = Uow.PessoaRepository.GetPessoaById(id);
            if (pessoaGetId == null)
                throw new DomainException($"Id não encontrado");

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PessoaGetAllDto, Pessoa>().ReverseMap();
            });

            var mapper = new Mapper(config);
            var pessoaEntity = mapper.Map<PessoaGetAllDto>(pessoaGetId);

            pessoaEntity.Idade = DateTimeHelper.GetIdade(pessoaEntity.DataNascimento);

            return pessoaEntity;
        }

        public void EditInfoPessoa(int id, PessoaEditInfoPutDto putEditInfoDto)
        {
            if (Uow.PessoaRepository.GetPessoaById(id) == null)
                throw new DomainException($"Id não encontrado");

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PessoaEditInfoPutDto, Pessoa>().ReverseMap();
            });

            var mapper = new Mapper(config);
            var pessoaEntity = mapper.Map<Pessoa>(putEditInfoDto);

            Validate(pessoaEntity);

            Uow.PessoaRepository.EditInfo(id, pessoaEntity);
        }

        public void EnableUser(int id)
        {
            var pessoa = Uow.PessoaRepository.GetPessoaById(id);
            if (pessoa == null)
                throw new DomainException($"Id não encontrado");
            if (pessoa.UsuarioAtivo == true)
                throw new DomainException($"Usuário já está ativado");

            Uow.PessoaRepository.EnableUser(id);
        }

        public void DisableUser(int id)
        {
            var pessoa = Uow.PessoaRepository.GetPessoaById(id);
            if (pessoa == null)
                throw new DomainException($"Id não encontrado");
            if (pessoa.UsuarioAtivo == false)
                throw new DomainException($"Usuário já está desativado");

            Uow.PessoaRepository.DisableUser(id);
        }

        public void AddFilho(int id, PessoaFilhosPutDto putFilhoDto)
        {
            var p = Uow.PessoaRepository.GetPessoaById(id);
            if (p == null)
                throw new DomainException($"Id não encontrado");

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PessoaFilhosPutDto, Pessoa>().ReverseMap();
            });

            var mapper = new Mapper(config);
            var pessoaEntity = mapper.Map<Pessoa>(putFilhoDto);

            pessoaEntity.Id = Uow.PessoaRepository.GetNextId();
            pessoaEntity.UsuarioAtivo = true;

            Validate(pessoaEntity);

            Uow.PessoaRepository.AddFilho(id, pessoaEntity);
        }
    }
}
