using Domain.Entities;
using System.Collections.Generic;

namespace Infrastructure.Repository.Interfaces
{
    public interface IEnderecoRepository
    {
        void Post(Endereco pessoa);
        IEnumerable<Endereco> GetAll();
        Endereco GetByCep(string cep);
        void Put(Endereco endereco);
    }
}
