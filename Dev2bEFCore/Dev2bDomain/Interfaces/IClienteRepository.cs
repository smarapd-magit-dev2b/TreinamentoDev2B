using Dev2bDomain.Entities;
using System.Collections.Generic;

namespace Dev2bDomain.Interfaces
{
    public interface IClienteRepository
    {
        ClienteEntity ObterClientePorId(int id);

        void AdicionarCliente(ClienteEntity cliente);

        IEnumerable<ClienteEntity> ListarClientes();
    }
}
