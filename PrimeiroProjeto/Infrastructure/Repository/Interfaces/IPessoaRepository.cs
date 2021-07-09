using Domain.Entities;
using System.Collections.Generic;

namespace Infrastructure.Repository.Interfaces
{
    public interface IPessoaRepository
    {
        int Post(Pessoa pessoa);

        List<Pessoa> Get();
        Pessoa GetPorId(int id);
        int Put(int id, Pessoa pessoa);
        int Delete(int id);
        int PutStatus(int id, bool status);
        int PutPessoaEssencial(int id, Pessoa pessoa);
    }
}
