using Dev2bDomain.Entities;
using Dev2bDomain.Interfaces;
using Dev2bServices.Interfaces;
using System;
using System.Collections.Generic;

namespace Dev2bAppilcation.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<ClienteEntity> ListarClientes()
        {
            return _clienteRepository.ListarClientes();
        }

        public void AdicionarCliente(ClienteEntity cliente)
        {
            if (_clienteRepository.ObterClientePorId(cliente.Id) != null)
                throw new Exception($"Já existe cliente com Id {cliente.Id}");

            if (string.IsNullOrEmpty(cliente.Nome))
                throw new Exception($"Nome do cliente não informado");

            if (cliente.Nome.Length < 3)
                throw new Exception($"Nome do cliente deve ser maior que 3 caracteres");


            _clienteRepository.AdicionarCliente(cliente);
        }
    }
}
