using Common.ClassHelpers;
using Common.Dto;
using Common.Exception;
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
        int _id = 0;
        public PessoaApplicationService(IPessoaUnitOfWork uow)
        {
            Uow = uow;
        }

        public int AdicionarPessoa(AddPessoaDto dto)
        {
            Pessoa pessoa = new Pessoa()
            {
                Nome = dto.Nome,
                SobreNome = dto.SobreNome,
                Cpf = dto.Cpf,
                Altura = dto.Altura,
                Id = AtribuirId(),
                UsuarioAtivo = true,
                Peso = dto.Peso,
                DataNascimento = dto.DataNascimento
            };
            Validate(pessoa);
            Uow.PessoaRepository.AddPessoa(pessoa);
            return pessoa.Id;
        }

        public void AtivarUsuario(int id)
        {
            Uow.PessoaRepository.AtivarUsuario(id); 
        }

        public void DeletarPessoa(int id)
        {
            ValidarDelete(id);
            Uow.PessoaRepository.DeletePessoa(id);
        }

        public void EditNomeSobrenomeCpf(int id, EditNomeSobrenomeCpfDto dto)
        {
            Pessoa pessoa = Uow.PessoaRepository.GetById(id);
            pessoa.Nome = dto.Nome;
            pessoa.SobreNome = dto.Sobrenome;
            pessoa.Cpf = dto.Cpf;
            Validate(pessoa);
            Uow.PessoaRepository.EditPessoa(id, pessoa);
        }

        public void EditPessoa(int id, EditPessoaDto dto)
        {
            Pessoa pessoa = Uow.PessoaRepository.GetById(id);
            pessoa.Nome = dto.Nome;
            pessoa.SobreNome = dto.Sobrenome;
            pessoa.Cpf = dto.Cpf;
            pessoa.Altura = dto.Altura;
            pessoa.DataNascimento = dto.DataNascimento;
            pessoa.Peso = dto.Peso;
            pessoa.Raca = dto.Raca;
            Validate(pessoa);
            Uow.PessoaRepository.EditPessoa(id, pessoa);
        }

        public List<PessoaGetAllDto> GetAll()
        {
            var lista = Uow.PessoaRepository.GetAll().Select(x => new PessoaGetAllDto
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
            return lista;
        }

        public PessoaGetByIdDto GetById(int id)
        {
            var pessoa = Uow.PessoaRepository.GetById(id);
            var dto = new PessoaGetByIdDto
            {
                Nome = pessoa.Nome,
                SobreNome = pessoa.SobreNome,
                Altura = pessoa.Altura,
                Peso = pessoa.Peso,
                DataNascimento = pessoa.DataNascimento,
                UsuarioAtivo = pessoa.UsuarioAtivo,
                Cpf = pessoa.Cpf,
                Id = pessoa.Id,
                Raca = pessoa.Raca
            };
            return dto;
        }
        private int AtribuirId() 
        {
            var id = Uow.PessoaRepository.GetAll().OrderByDescending(x => x.Id).FirstOrDefault();
            return ++id.Id;
        }


        private void Validate(Pessoa pessoa)
        {
            if (pessoa.Nome.Length < 5)
                throw new DomainException("O Campo Nome é menor que 5 caracteres.");

            if (string.IsNullOrEmpty(pessoa.Nome))
                throw new DomainException("O Campo Nome é obrigátorio.");

            if (string.IsNullOrEmpty(pessoa.SobreNome))
                throw new DomainException("O Campo SobreNome é obrigátorio.");

            if (string.IsNullOrEmpty(pessoa.Cpf))
                throw new DomainException("O Campo Cpf é obrigátorio.");
            if (!CpfHelper.IsCpf(pessoa.Cpf))
                throw new DomainException("O Campo Cpf é invalido.");

            if (IdadeHelper.CalcularIdade(pessoa.DataNascimento) < 18)
                throw new DomainException("Pessoa tem idade menor que 18 anos.");
            
        }
        private void ValidarDelete(int id)
        {
            if (!Uow.PessoaRepository.GetById(id).UsuarioAtivo)
                throw new DomainException("Usuario é ativo.");

        }
    }
}
