using Domain.Entities;
using System.Collections.Generic;

namespace Infrastructure.Repository.Interfaces
{
    public interface IPessoaRepository
    {
        int PostPessoa(Pessoa pessoa);

        List<Pessoa> GetPessoas();
        Pessoa GetPorId(int id);
        int PutPessoa(int id, Pessoa pessoa);
        int DeletePorId(int id);
        int PutStatus(int id, bool status);
    }
}
