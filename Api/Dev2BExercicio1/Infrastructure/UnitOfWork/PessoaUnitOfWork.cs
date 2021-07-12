﻿using Infrastructure.Repository.Interfaces;
using Infrastructure.UnitOfWork.Interfaces;

namespace Infrastructure.UnitOfWork
{
    public class PessoaUnitOfWork : IPessoaUnitOfWork
    {
        public IPessoaRepository PessoaRepository { get; }

        public PessoaUnitOfWork(IPessoaRepository _pessoaRepository)
        {
            PessoaRepository = _pessoaRepository;
        }
    }
}
