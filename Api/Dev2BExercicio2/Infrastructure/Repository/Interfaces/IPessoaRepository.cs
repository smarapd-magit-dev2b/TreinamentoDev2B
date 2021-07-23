using System.Collections.Generic;
using Common.Entities;

namespace Infrastructure.Repository.Interfaces
{
    public interface IPessoaRepository
    {
        void Add(Pessoa pessoa);
        int GetNextId();
        void Delete(Pessoa pessoa);
        void Edit(Pessoa pessoa);
        void EditInfo(Pessoa pessoa);
        void EnableUser(Pessoa pessoa);
        void DisableUser(Pessoa pessoa);
        Pessoa GetPessoaById(int id);
        List<Pessoa> GetAll();
    }
}
