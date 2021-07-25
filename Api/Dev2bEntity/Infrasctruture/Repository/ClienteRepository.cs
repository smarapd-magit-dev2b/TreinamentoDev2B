using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Infrasctruture.Model;
using Infrasctruture.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrasctruture.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly Dev2bEntityDbContext _dev2BEntityDbContext;

        public ClienteRepository(Dev2bEntityDbContext dev2BEntityDbContext)
        {
            _dev2BEntityDbContext = dev2BEntityDbContext;
        }

        public void Delete(Cliente cliente)
        {
            _dev2BEntityDbContext.Clientes.Remove(cliente);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _dev2BEntityDbContext.Clientes.AsNoTracking().ToList();
        }

        public Cliente GetById(int id)
        {
            return _dev2BEntityDbContext.Clientes.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public void Post(Cliente cliente)
        {
            _dev2BEntityDbContext.Clientes.Add(cliente);
        }

        public void Put(Cliente cliente)
        {
            _dev2BEntityDbContext.Clientes.Update(cliente);
        }
    }
}
