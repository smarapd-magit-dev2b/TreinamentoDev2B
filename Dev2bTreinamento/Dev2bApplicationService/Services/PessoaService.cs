using Dev2bAppilcation.Helpers;
using Dev2bDomain.Entities;
using Dev2bDomain.Interfaces;
using Dev2bServices.Interfaces;
using System;
using System.Collections.Generic;

namespace Dev2bAppilcation.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _clienteRepository;

        public PessoaService(IPessoaRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public List<PessoaEntity> ObterTodosOsClientes()
        {
            if (_clienteRepository.ObterTodosOsClientes() == null)
                throw new Exception($"Não há pessoas cadastrados");

            return _clienteRepository.ObterTodosOsClientes();
        }

        public PessoaEntity ObterClientePorId(int id)
        {
            var pessoa = _clienteRepository.ObterPessoaPorId(id);

            PessoaServiceHelper.NaoExistePessoaComId(id, pessoa);

            return _clienteRepository.ObterPessoaPorId(id);
        }

        public void AdicionarCliente(PessoaEntity pessoa)
        {
            if (_clienteRepository.ObterPessoaPorId(pessoa.Id) != null)
                throw new Exception($"Já existe uma pessoa com Id {pessoa.Id}");

            PessoaServiceHelper.NomeNaoInformado(pessoa);

            PessoaServiceHelper.NomeMaiorQue5Caracteres(pessoa);

            PessoaServiceHelper.MaiorDeIdade(pessoa);


            _clienteRepository.AdicionarCliente(pessoa);
        }
        public void AlterarPessoa(int id, PessoaEntity pessoa)
        {
            PessoaServiceHelper.NaoExistePessoaComId
            (
                id,
                _clienteRepository.ObterPessoaPorId(id)
            );

            PessoaServiceHelper.NomeNaoInformado(pessoa);

            PessoaServiceHelper.NomeMaiorQue5Caracteres(pessoa);

            PessoaServiceHelper.MaiorDeIdade(pessoa);

            _clienteRepository.AlterarPessoa(id, pessoa);
        }

        public void DeletarPessoa(int id)
        {
            var pessoa = _clienteRepository.ObterPessoaPorId(id);

            PessoaServiceHelper.NaoExistePessoaComId(id, pessoa);

            if (_clienteRepository.ObterPessoaPorId(id).UsuarioAtivo)
                throw new Exception($"Pessoa com Id {id} está ativa e não pode ser deletado");

            _clienteRepository.DeletarPessoa(id);
        }
    }
}
