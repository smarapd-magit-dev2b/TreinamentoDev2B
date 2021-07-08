using Domain.Entities;
using System.Collections.Generic;

namespace Infrastructure.Repository.Interfaces
{
    public interface IPessoaRepository
    {
        int PostPessoa(Pessoa pessoa);

        List<Pessoa> GetPessoas();
        Pessoa GetPessoaPorId(int id);
    }
}
