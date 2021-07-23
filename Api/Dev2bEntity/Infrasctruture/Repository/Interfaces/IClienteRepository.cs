using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace Infrasctruture.Repository.Interfaces
{
    public interface IClienteRepository
    {
        void Post(Cliente cliente);
        void Put(Cliente cliente);
        void Delete(Cliente cliente);
        IEnumerable<Cliente> GetAll();
        Cliente GetById(int id);

    }
}
