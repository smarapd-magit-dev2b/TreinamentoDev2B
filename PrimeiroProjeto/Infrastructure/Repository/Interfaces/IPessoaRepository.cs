using Domain.Entities;
using System.Collections.Generic;

namespace Infrastructure.Repository.Interfaces
{
    public interface IPessoaRepository
    {
        List<Pessoa> GetPessoas();
    }
}
