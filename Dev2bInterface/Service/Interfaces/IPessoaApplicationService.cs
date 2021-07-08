using Common.Dto;
using Domain.Entities;
using Infrastructure.UnitOfWork.Interface;
using Service.ApplicationService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.ApplicationService
{
    public class PessoaApplicationService : IPessoaApplicationService
    {
        private readonly IPessoaUnitOfWork Uow;

        public PessoaApplicationService(IPessoaUnitOfWork pessoaUnitOfWork)
        {
            Uow = pessoaUnitOfWork;
        }
        public int AdicionarPessoa(PessoaPostDto dto)
        {
            Pessoa pessoa = new Pessoa()
            {
                Nome = dto.Nome,
                SobreNome = dto.SobreNome,
                Cpf = dto.Cpf,
                Altura = dto.Altura,
                Id = dto.Id,
                UsuarioAtivo = true,
                Peso = dto.Peso,
            };



            Validate(pessoa);

            Uow.PessoaRepository.Adicionar(pessoa);

            return pessoa.Id;
        }

        private void Validate(Pessoa pessoa)
        {
            if (string.IsNullOrEmpty(pessoa.Nome))
                throw new Exception("O Campo Nome é obrigátorio.");

            if (string.IsNullOrEmpty(pessoa.SobreNome))
                throw new Exception("O Campo SobreNome é obrigátorio.");

            if (string.IsNullOrEmpty(pessoa.Cpf))
                throw new Exception("O Campo Cpf é obrigátorio.");

        }

        public List<PessoaGetAllDto> GetAll()
        {
            var dto = Uow.PessoaRepository.GetAll().Select(x => new PessoaGetAllDto
            {
                Nome = x.Nome,
                SobreNome = x.SobreNome,
                Altura = x.Altura,
                Peso = x.Peso,
                DataNascimento = x.DataNascimento,
                UsuarioAtivo = x.UsuarioAtivo,
                Cpf = x.Cpf,
                Id = x.Id,
                Raca = x.Raca
            }).ToList();

            return dto;
        }

        public List<PessoaGetAllCpfDto> GetAllCpf()
        {
            var dto = Uow.PessoaRepository.GetAll().Select(x => new PessoaGetAllCpfDto
            {
                Cpf = x.Cpf,
            }).ToList();

            return dto;
        }
    }
}
