using System.Collections.Generic;
using Domain.Entities;

namespace Infrastructure.Repository.Interfaces
{
    public interface IPessoaRepository
    {
        void Adicionar(Pessoa pessoa);
        void Editar(int id, Pessoa pessoa);
        void Deletar(Pessoa pessoa);
        Pessoa GetPessoaPorId(int id);
        List<Pessoa> GetAll();
    }
}
