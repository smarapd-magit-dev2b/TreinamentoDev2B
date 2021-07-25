using System.Collections.Generic;
using Domain.Entities;

namespace Infrasctruture.Repository.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetAll();
        Produto GetById(int id);
        void Post(Produto produto);
        void Put(Produto produto);
        void Delete(Produto produto);
    }
}
