using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application {
    public class PessoaService : IPessoaService {

        private readonly IPessoaRepository _pessoarepository;

        public PessoaService(IPessoaRepository pessoarepository) {
            _pessoarepository = pessoarepository;
        }

        public void AdicionarPessoa(Pessoa pessoa) {
            if (_pessoarepository.ObterPessoaPorID(pessoa.Id) != null)
                throw new Exception($"Já existe pessoa cadastrada com esse id: {pessoa.Id}");
            if (string.IsNullOrEmpty(pessoa.Nome))
                throw new Exception($"Nome da pessoa não informada...");
            if (pessoa.Nome.Length < 5)
                throw new Exception($"Nome da pessoa deve ser maior que 5 caracteres...");

            _pessoarepository.AdicionarPessoa(pessoa);
        }

        public void AtualizarPessoa(Pessoa pessoa) {
            if (_pessoarepository.ObterPessoaPorID(pessoa.Id) == null)
                throw new Exception($"Não tem ninguém registrado com esse ID: {pessoa.Id} ");
            
            _pessoarepository.AtualizarPessoa(pessoa);
        }

        public void DeletarPessoa(Pessoa pessoa) {
            throw new NotImplementedException();
        }

        public void ListarPessoa(Pessoa pessoa) {
            throw new NotImplementedException();
        }
    }
}
