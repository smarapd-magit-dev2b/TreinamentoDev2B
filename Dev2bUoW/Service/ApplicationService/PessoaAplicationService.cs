using Common.Dto;
using Common.NewFolder;
using Domain.Entities;
using Infrastructure.UnitOfWork.Interfaces;
using Service.ApplicationService.Interfaces;
using System.Collections.Generic;

namespace Service.ApplicationService
{
    public class PessoaAplicationService : IPessoaApplicationService
    {
        private readonly IDev2bUnitOfWork Uow;

        public PessoaAplicationService(IDev2bUnitOfWork pessoaUnitOfWork)
        {
            Uow = pessoaUnitOfWork;
        }

        public IEnumerable<PessoaGetAllDto> GetAll()
        {
            var pessoas = new List<PessoaGetAllDto>();

            foreach (var pessoa in Uow.PessoaRepository.GetAll())
            {
                var dto = new PessoaGetAllDto()
                {
                    Id = pessoa.Id,
                    Nome = pessoa.Nome,
                    SobreNome = pessoa.SobreNome,
                    DataNascimento = pessoa.DataNascimento,
                    Cpf = pessoa.CPF,
                    Numero = pessoa.Numero,
                    Cep = pessoa.Endereco.Cep,
                    Logradouro = pessoa.Endereco.Logradouro,
                    Bairro = pessoa.Endereco.Bairro
                };
                pessoas.Add(dto);
            }

            return pessoas;
        }

        public int Post(PessoaPostDto dto)
        {
            var pessoa = new Pessoa()
            {
                Nome = dto.Nome,
                SobreNome = dto.SobreNome,
                CPF = dto.Cpf,
                DataNascimento = dto.DataNascimento,
                Numero = dto.Numero
            };

            Validate(pessoa);

            var endereco = Uow.EnderecoRepository.GetByCep(dto.Cep);

            if (endereco == null)
            {
                //Se endereço não existe, inserir
                endereco = new Endereco()
                {
                    Cep = dto.Cep,
                    Logradouro = dto.Logradouro,
                    Bairro = dto.Bairro
                };

                pessoa.Endereco = endereco;
            }
            else
            {
                //Se endereço existe, atualizar
                endereco.Logradouro = dto.Logradouro;
                endereco.Bairro = dto.Bairro;
                Uow.EnderecoRepository.Put(endereco);
                pessoa.EnderecoId = endereco.Id;
            }

            Uow.PessoaRepository.Post(pessoa);

            Uow.Commit();

            return pessoa.Id;
        }

        private void Validate(Pessoa pessoa)
        {
            if (string.IsNullOrEmpty(pessoa.Nome))
                throw new DomainException("O campo Nome é obrigátorio.");

            if (string.IsNullOrEmpty(pessoa.SobreNome))
                throw new DomainException("O campo SobreNome é obrigátorio.");

            if (string.IsNullOrEmpty(pessoa.CPF))
                throw new DomainException("O campo CPF é obrigátorio.");

        }
    }
}
