using Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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