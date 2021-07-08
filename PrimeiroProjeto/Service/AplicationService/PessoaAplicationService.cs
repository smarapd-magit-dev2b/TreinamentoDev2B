using Commom.Dto;
using Commom.Exceptions;
using Commom.Helpers;
using Domain.Entities;
using Infrastructure.UnitOfWork.Interfaces;
using Service.AplicationService.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Service.AplicationService
{
    public class PessoaAplicationService : IPessoaAplicationService
    {
        private readonly IPessoaUnitOfWork _uow;
        private int _id;

        public PessoaAplicationService(IPessoaUnitOfWork uow)
        {
            _uow = uow;
            _id = _uow.PessoaRepository.GetPessoas().Count;
        }

        public List<PessoaGetDto> GetAllDtos() => _uow.PessoaRepository.GetPessoas() != null
                ? _uow.PessoaRepository.GetPessoas()
                .Select(p => new PessoaGetDto
                {
                    Nome = p.Name,
                    SobreNome = p.LastName,
                    Altura = p.Height,
                    Peso = p.Weight,
                    DataNascimento = p.BirthDate,
                    UsuarioAtivo = p.Status,
                    DocumentoCpf = p.Cpf,
                    Codigo = p.Id,
                    Raca = p.Race
                }).ToList()
                : throw new NegocioException("Não há Pessoas cadastradas");

        public PessoaGetDto GetDtoPorId(int id)
        {
            if (_uow.PessoaRepository.GetPessoaPorId(id) == null)
                throw new NegocioException($"Id {id} não encontrado");

            Pessoa pessoa = _uow.PessoaRepository.GetPessoaPorId(id);

            return new PessoaGetDto()
            {
                Nome = pessoa.Name,
                SobreNome = pessoa.LastName,
                Altura = pessoa.Height,
                Peso = pessoa.Weight,
                DataNascimento = pessoa.BirthDate,
                UsuarioAtivo = pessoa.Status,
                DocumentoCpf = pessoa.Cpf,
                Codigo = pessoa.Id,
                Raca = pessoa.Race
            };
        }

        public int PostDto(PessoaPostDto pessoaDto)
        {
            //if (_uow.PessoaRepository.GetPessoaPorId(id) != null)
            //    throw new NegocioException($"Pessoa com Id {id} Já existe");

            if (DateTimeHelper.Idade(pessoaDto.DataNascimento) < 18)
                throw new NegocioException("Só é aceito maiores de idade");

            if (string.IsNullOrEmpty(pessoaDto.Nome))
                throw new NegocioException("O campo Nome deve ser preenchido");

            if (pessoaDto.Nome.Length < 5)
                throw new NegocioException("O Nome não pode ter menos de 5 letras");

            if (string.IsNullOrEmpty(pessoaDto.SobreNome))
                throw new NegocioException("O campo Sobrenome deve ser preenchido");

            if (string.IsNullOrEmpty(pessoaDto.DocumentoCpf))
                throw new NegocioException("O campo Cpf deve ser preenchido");

            if (!CpfHelper.Valido(pessoaDto.DocumentoCpf))
                throw new NegocioException("Cpf inválido");

            return _uow.PessoaRepository.PostPessoa(
                new Pessoa
                {
                    Name = pessoaDto.Nome,
                    BirthDate = pessoaDto.DataNascimento,
                    Cpf = pessoaDto.DocumentoCpf,
                    Height = pessoaDto.Altura,
                    Id = ++_id,
                    LastName = pessoaDto.SobreNome,
                    Race = pessoaDto.Raca,
                    Status = true,
                    Weight = pessoaDto.Peso
                });
        }

        public int PutDto(int id, PessoaPostDto pessoaDto)
        {
            throw new System.NotImplementedException();
        }
    }
}
