using Dev2bDomain.Entities;
using Dev2bDomain.Interfaces;
using Dev2bRepositories;
using System.Collections.Generic;
using System.Linq;

namespace Dev2bRepository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly Dev2bDbContext _dbContext;

        public ClienteRepository(Dev2bDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AdicionarCliente(ClienteEntity cliente)
        {
            _dbContext.Clientes.Add(cliente);

            _dbContext.SaveChanges();
        }

        public ClienteEntity ObterClientePorId(int id)
        {
            return _dbContext.Clientes.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<ClienteEntity> ListarClientes()
        {
            return _dbContext.Clientes.ToList();
        }
    }
}
