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

        public PessoaAplicationService(IPessoaUnitOfWork uow) => _uow = uow;

        public List<PessoaGetDto> Get() => _uow.PessoaRepository.GetPessoas() != null
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

        public PessoaGetDto GetPorCodigo(int codigo)
        {
            if (_uow.PessoaRepository.GetPorId(codigo) == null)
                throw new NegocioException($"Pessoa com Id {codigo} não encontrada");

            Pessoa pessoa = _uow.PessoaRepository.GetPorId(codigo);

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

        public int Post(PessoaPostDto pessoaDto)
        {
            PessoaValidate(pessoaDto);

            return _uow.PessoaRepository.PostPessoa(
                new Pessoa
                {
                    Name = pessoaDto.Nome,
                    BirthDate = pessoaDto.DataNascimento,
                    Cpf = pessoaDto.DocumentoCpf,
                    Height = pessoaDto.Altura,
                    Id = _uow.PessoaRepository.GetPessoas().Max(p => p.Id) + 1,
                    LastName = pessoaDto.SobreNome,
                    Race = pessoaDto.Raca,
                    Status = true,
                    Weight = pessoaDto.Peso
                });
        }

        public int Put(int codigo, PessoaPostDto pessoaDto)
        {
            CodigoValidate(codigo);

            PessoaValidate(pessoaDto);

            return _uow.PessoaRepository.PutPessoa(
                codigo,
                new Pessoa
                {
                    Name = pessoaDto.Nome,
                    BirthDate = pessoaDto.DataNascimento,
                    Cpf = pessoaDto.DocumentoCpf,
                    Height = pessoaDto.Altura,
                    Id = codigo,
                    LastName = pessoaDto.SobreNome,
                    Race = pessoaDto.Raca,
                    Status = true,
                    Weight = pessoaDto.Peso
                });
        }

        public int DeletePorCodigo(int codigo)
        {
            CodigoValidate(codigo);

            if (_uow.PessoaRepository.GetPorId(codigo).Status)
                throw new NegocioException("Não é possível deletar usuários ativos");

            return _uow.PessoaRepository.DeletePorId(codigo);
        }

        private void PessoaValidate(PessoaPostDto pessoaDto)
        {
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
        }

        private void CodigoValidate(int codigo)
        {
            if (_uow.PessoaRepository.GetPorId(codigo) == null)
                throw new NegocioException($"Pessoa com Código {codigo} não existe");
        }
    }
}
