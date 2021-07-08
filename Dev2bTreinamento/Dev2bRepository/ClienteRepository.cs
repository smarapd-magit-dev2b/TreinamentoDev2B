using Dev2bDomain.Entities;
using Dev2bDomain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Dev2bRepository
{
    public class ClienteRepository : IClienteRepository
    {
        private List<ClienteEntity> clientes;

        public ClienteRepository()
        {
            clientes = new List<ClienteEntity>
            {
                new ClienteEntity { Id = 1, Nome = "Gabriel" },
                new ClienteEntity { Id = 2, Nome = "Glenison" }
            };
        }

        public void AdicionarCliente(ClienteEntity cliente)
        {
            clientes.Add(cliente);
        }

        public ClienteEntity ObterClientePorId(int id)
        {
            var cliente = clientes.Where(p => p.Id == id).FirstOrDefault();

            if (cliente == null)
                return null;

            return cliente;
        }
    }
}
