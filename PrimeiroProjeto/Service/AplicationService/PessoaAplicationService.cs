using Commom.Dto;
using Commom.Exceptions;
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
                    Documento = p.Cpf,
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
                Documento = pessoa.Cpf,
                Codigo = pessoa.Id,
                Raca = pessoa.Race
            };
        }
    }
}
