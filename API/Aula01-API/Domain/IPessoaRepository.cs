using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain {
    public interface IPessoaRepository {

        public int? ObterPessoaPorID(int i);
        public void AdicionarPessoa(Pessoa pessoa);
        public void DeletarPessoa();
        public void AtualizarPessoa(Pessoa pessoa);
        List<Pessoa> ListarPessoa();
    }
}
