using System.Collections.Generic;
using System.Linq;
using Common.Dtos;
using Common.Exceptions;
using Common.Helpers;
using Domain.Entities;
using Infrastructure.UnitOfWork.Interfaces;
using Service.ApplicationService.Interfaces;

namespace Service.ApplicationService
{
    public class PessoaApplicationService : IPessoaApplicationService
    {
        private readonly IPessoaUnitOfWork Uow;

        public PessoaApplicationService(IPessoaUnitOfWork pessoaUnitOfWork)
        {
            Uow = pessoaUnitOfWork;
        }

        public int AdicionarPessoa(PessoaPostDto postDto)
        {
            Pessoa pessoa = new Pessoa()
            {
                Id = IdHelper.GenerateId(),
                Nome = postDto.Nome,
                DataNascimento = postDto.DataNascimento,
                Altura = postDto.Altura,
                Peso = postDto.Peso,
                Raca = postDto.Raca,
                UsuarioAtivo = true
            };
            Validate(pessoa);

            Uow.PessoaRepository.Adicionar(pessoa);

            return pessoa.Id;
        }

        public void DeletarPessoa(int id)
        {
            var pessoaId = Uow.PessoaRepository.GetPessoaPorId(id);
            if(pessoaId == null)
                throw new DomainException($"Id não encontrado");
            if(pessoaId.UsuarioAtivo == true)
                throw new DomainException($"Não é possível deletar usuário Ativo");

            var deletarPessoa = pessoaId;
            Uow.PessoaRepository.Deletar(deletarPessoa);
        }

        public void EditarPessoa(int id, PessoaPutDto putDto)
        {
            Pessoa pessoa = new Pessoa()
            {
                Nome = putDto.Nome,
                DataNascimento = putDto.DataNascimento,
                Altura = putDto.Altura,
                Peso = putDto.Peso,
                Raca = putDto.Raca,
            };

            Validate(pessoa);

            Uow.PessoaRepository.Editar(id, pessoa);
        }

        public List<PessoaGetAllDto> GetAll()
        {
            var dto = Uow.PessoaRepository.GetAll().Select(p => new PessoaGetAllDto
            {
                Id = p.Id,
                Nome = p.Nome,
                DataNascimento = p.DataNascimento,
                Altura = p.Altura,
                Peso = p.Peso,
                Raca = p.Raca,
                Idade = DateTimeHelper.GetIdade(p.DataNascimento),
                UsuarioAtivo = p.UsuarioAtivo,
            }).ToList();
            
            return dto;
        }

        public PessoaGetAllDto GetPessoaId(int id)
        {
            var pessoaGetId = Uow.PessoaRepository.GetPessoaPorId(id);
            if(pessoaGetId == null)
                throw new DomainException($"Id não encontrado");

            var dto = new PessoaGetAllDto
            {
                Id = pessoaGetId.Id,
                Nome = pessoaGetId.Nome,
                DataNascimento = pessoaGetId.DataNascimento,
                Altura = pessoaGetId.Altura,
                Peso = pessoaGetId.Peso,
                Raca = pessoaGetId.Raca,
                Idade = DateTimeHelper.GetIdade(pessoaGetId.DataNascimento),
                UsuarioAtivo = pessoaGetId.UsuarioAtivo,
            };
            return dto;
        }

        private void Validate(Pessoa pessoa)
        {
            if(DateTimeHelper.GetIdade(pessoa.DataNascimento) < 18)
                throw new DomainException($"Cadastro válido apenas para pessoas maiores de 18 anos");
            if(string.IsNullOrEmpty(pessoa.Nome))
                throw new DomainException($"O campo Nome é obrigatório");
            if(pessoa.Nome.Length < 5)
                throw new DomainException($"O campo Nome deve ter no mínimo 5 letras");
        }
    }
}
