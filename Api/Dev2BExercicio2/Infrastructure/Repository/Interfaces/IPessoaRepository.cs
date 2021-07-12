using System.Collections.Generic;
using Common.Entities;

namespace Infrastructure.Repository.Interfaces
{
    public interface IPessoaRepository
    {
        void Add(Pessoa pessoa);
        int GetNextId();
        void AddFilho(int id, Pessoa filho);
        void Delete(Pessoa pessoa);
        void Edit(int id, Pessoa pessoa);
        void EditInfo(int id, Pessoa pessoa);
        void EnableUser(int id);
        void DisableUser(int id);
        Pessoa GetPessoaById(int id);
        List<Pessoa> GetAll();
    }
}
