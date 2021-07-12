using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application {
    public interface IPessoaService {
        public void AdicionarPessoa(Pessoa pessoa);
        public void DeletarPessoa(Pessoa pessoa);
        public void AtualizarPessoa(Pessoa pessoa);
        public void ListarPessoa(Pessoa pessoa);
    }
}
