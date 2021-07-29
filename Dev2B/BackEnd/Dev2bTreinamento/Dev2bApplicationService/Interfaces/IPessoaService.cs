using Dev2bDomain.Entities;
using System.Collections.Generic;

namespace Dev2bServices.Interfaces
{
    public interface IPessoaService
    {
        void AdicionarPessoa(PessoaEntity pessoa);
        void AlterarPessoa(int id, PessoaEntity pessoa);
        void DeletarPessoa(int id);
        PessoaEntity ObterPessoaPorId(int id);
        List<PessoaEntity> ObterTodosAsPessoas();
    }
}
