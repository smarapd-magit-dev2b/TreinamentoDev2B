using Domain.Entities;
using System.Collections.Generic;

namespace Infrastructure.Repository.Interfaces
{
    public interface IPessoaRepository
    {
        void Adicionar(Pessoa pessoa);
        List<Pessoa> GetAll();
    }
}
