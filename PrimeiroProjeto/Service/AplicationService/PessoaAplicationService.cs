using Commom.Dto;
using Commom.Exceptions;
using Infrastructure.UnitOfWork.Interfaces;
using Service.AplicationService.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Service.AplicationService
{
    public class PessoaAplicationService : IPessoaAplicationService
    {
        private readonly IPessoaUnitOfWork Uow;

        public PessoaAplicationService(IPessoaUnitOfWork uow) => Uow = uow;

        public List<PessoaGetAllDto> GetAllDtos() => Uow.PessoaRepository.GetPessoas() != null
                ? Uow.PessoaRepository.GetPessoas()
                .Select(p => new PessoaGetAllDto
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
    }
}
