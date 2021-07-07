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
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public List<PessoaEntity> ObterTodosAsPessoas()
        {
            if (_pessoaRepository.ObterTodosOsPessoas() == null)
                throw new Exception($"Não há pessoas cadastrados");

            return _pessoaRepository.ObterTodosOsPessoas();
        }

        public PessoaEntity ObterPessoaPorId(int id)
        {
            var pessoa = _pessoaRepository.ObterPessoaPorId(id);

            PessoaServiceHelper.NaoExistePessoaComId(id, pessoa);

            return _pessoaRepository.ObterPessoaPorId(id);
        }

        public void AdicionarPessoa(PessoaEntity pessoa)
        {
            if (_pessoaRepository.ObterPessoaPorId(pessoa.Id) != null)
                throw new Exception($"Já existe uma pessoa com Id {pessoa.Id}");

            PessoaServiceHelper.NomeNaoInformado(pessoa);

            PessoaServiceHelper.NomeMaiorQue5Caracteres(pessoa);

            PessoaServiceHelper.MaiorDeIdade(pessoa);


            _pessoaRepository.AdicionarPessoa(pessoa);
        }
        public void AlterarPessoa(int id, PessoaEntity pessoa)
        {
            PessoaServiceHelper.NaoExistePessoaComId
            (
                id,
                _pessoaRepository.ObterPessoaPorId(id)
            );

            if (pessoa.Id != id)
                throw new Exception($"Id da pessoa difere do Id a ser alterado");

            PessoaServiceHelper.NomeNaoInformado(pessoa);

            PessoaServiceHelper.NomeMaiorQue5Caracteres(pessoa);

            PessoaServiceHelper.MaiorDeIdade(pessoa);

            _pessoaRepository.AlterarPessoa(id, pessoa);
        }

        public void DeletarPessoa(int id)
        {
            var pessoa = _pessoaRepository.ObterPessoaPorId(id);

            PessoaServiceHelper.NaoExistePessoaComId(id, pessoa);

            if (_pessoaRepository.ObterPessoaPorId(id).UsuarioAtivo)
                throw new Exception($"Pessoa com Id {id} está ativa e não pode ser deletado");

            _pessoaRepository.DeletarPessoa(id);
        }
    }
}
