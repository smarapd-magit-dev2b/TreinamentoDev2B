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
        #region Get
        public List<PessoaGetDto> Get() => _uow.PessoaRepository.Get() != null
                ? _uow.PessoaRepository.Get()
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
            CodigoValidate(codigo);

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
        #endregion
        public int Post(PessoaPostDto pessoaDto)
        {
            PessoaValidate(pessoaDto);

            return _uow.PessoaRepository.Post(
                new Pessoa
                {
                    Name = pessoaDto.Nome,
                    BirthDate = pessoaDto.DataNascimento,
                    Cpf = pessoaDto.DocumentoCpf,
                    Height = pessoaDto.Altura,
                    Id = _uow.PessoaRepository.Get().Max(p => p.Id) + 1,
                    LastName = pessoaDto.SobreNome,
                    Race = pessoaDto.Raca,
                    Status = true,
                    Weight = pessoaDto.Peso
                });
        }
        #region Put
        public int Put(int codigo, PessoaPostDto pessoaDto)
        {
            CodigoValidate(codigo);

            PessoaValidate(pessoaDto);

            return _uow.PessoaRepository.Put(
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

        public int PutEssencial(int codigo, PessoaPutEssencialDto pessoaDto)
        {
            CodigoValidate(codigo);

            PessoaValidateEssencial(pessoaDto);

            return _uow.PessoaRepository.PutPessoaEssencial(codigo, new Pessoa
            {
                Name = pessoaDto.Nome,
                LastName = pessoaDto.SobreNome,
                Cpf = pessoaDto.DocumentoCpf
            });
        }

        public int PutUsuarioAtivo(int codigo, bool usuario)
        {
            CodigoValidate(codigo);

            if (usuario == _uow.PessoaRepository.GetPorId(codigo).Status)
                throw new NegocioException($"Pessoa com Código {codigo} {(usuario ? "já está ativa" : "já está desativada")}");

            return _uow.PessoaRepository.PutStatus(codigo, usuario);
        }
        #endregion
        public int Delete(int codigo)
        {
            CodigoValidate(codigo);

            if (_uow.PessoaRepository.GetPorId(codigo).Status)
                throw new NegocioException("Não é possível deletar usuários ativos");

            return _uow.PessoaRepository.Delete(codigo);
        }
        #region Validate
        private void PessoaValidateEssencial(PessoaPutEssencialDto pessoaDto)
        {
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
        private void PessoaValidate(PessoaPostDto pessoaDto)
        {
            PessoaValidateEssencial(new PessoaPutEssencialDto()
            {
                Nome = pessoaDto.Nome,
                SobreNome = pessoaDto.SobreNome,
                DocumentoCpf = pessoaDto.DocumentoCpf
            });

            if (DateTimeHelper.Idade(pessoaDto.DataNascimento) < 18)
                throw new NegocioException("Só é aceito maiores de idade");
        }

        private void CodigoValidate(int codigo)
        {
            if (_uow.PessoaRepository.GetPorId(codigo) == null)
                throw new NegocioException($"Pessoa com Código {codigo} não existe");
        }
        #endregion
    }
}
