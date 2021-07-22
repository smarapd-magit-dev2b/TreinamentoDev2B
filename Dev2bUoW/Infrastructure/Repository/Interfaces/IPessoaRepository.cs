using Domain.Entities;
using System.Collections.Generic;

namespace Infrastructure.Repository.Interfaces
{
    public interface IPessoaRepository
    {
        void Post(Pessoa pessoa);
        IEnumerable<Pessoa> GetAll();
        Pessoa Get(int id);
    }
}
