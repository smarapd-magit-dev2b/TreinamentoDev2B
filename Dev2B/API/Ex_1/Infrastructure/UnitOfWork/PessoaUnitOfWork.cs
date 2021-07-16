using Infrastructure.Repository.Interface;
using Infrastructure.UnitOfWork.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.UnitOfWork
{
     public class PessoaUnitOfWork : IPessoaUnitOfWork
    {
        public IPessoaRepository PessoaRepository { get; }

        public PessoaUnitOfWork(IPessoaRepository pessoaRepository)
        {
            PessoaRepository = pessoaRepository;
        }
    }
}
 