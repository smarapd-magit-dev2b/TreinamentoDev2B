﻿using Dev2bDomain.Entities;
using System.Collections.Generic;

namespace Dev2bDomain.Interfaces
{
    public interface IPessoaRepository
    {
        PessoaEntity ObterPessoaPorId(int id);

        void AdicionarCliente(PessoaEntity cliente);
        void AlterarPessoa(int id, PessoaEntity pessoa);
        void DeletarPessoa(int id);
        List<PessoaEntity> ObterTodosOsClientes();
    }
}
