using Dev2bDomain.Entities;

namespace Dev2bDomain.Interfaces
{
    public interface IClienteRepository
    {
        ClienteEntity ObterClientePorId(int id);

        void AdicionarCliente(ClienteEntity cliente);
    }
}
