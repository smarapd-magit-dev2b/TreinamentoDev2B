using Dev2bDomain.Entities;
using System.Collections.Generic;

namespace Dev2bServices.Interfaces
{
    public interface IPessoaService
    {
        void AdicionarCliente(PessoaEntity cliente);
        void AlterarPessoa(int id, PessoaEntity pessoa);
        void DeletarPessoa(int id);
        PessoaEntity ObterClientePorId(int id);
        List<PessoaEntity> ObterTodosOsClientes();
    }
}
