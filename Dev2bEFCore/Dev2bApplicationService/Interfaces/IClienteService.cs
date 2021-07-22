using Dev2bDomain.Entities;
using System.Collections.Generic;

namespace Dev2bServices.Interfaces
{
    public interface IClienteService
    {
        void AdicionarCliente(ClienteEntity cliente);

        IEnumerable<ClienteEntity> ListarClientes();
    }
}
