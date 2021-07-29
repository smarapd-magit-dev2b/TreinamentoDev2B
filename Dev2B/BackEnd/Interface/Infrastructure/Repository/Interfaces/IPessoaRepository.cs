using Commom.Dto;
using Domain.Entities;
using System.Collections.Generic;

namespace Infrastructure.Repository.Interfaces
{
    public interface IPessoaRepository
    {
        void Adicionar(PessoaPostDto pessoa);
        List<Pessoa> GetAll { get; }
    }
}
