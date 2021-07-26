using System;
using System.Collections.Generic;
using System.Text;
using Infrasctruture.Model;
using Infrasctruture.Repository.Interfaces;
using Infrasctruture.UnitOfWork.Interfaces;

namespace Infrasctruture.UnitOfWork
{
    public class ProdutoUnitOfWork : IProdutoUnitOfWork
    {
        private readonly Dev2bEntityDbContext _dev2BEntityDbContext;
        public IProdutoRepository ProdutoRepository { get; }

        public ProdutoUnitOfWork(Dev2bEntityDbContext dev2BEntityDbContext, IProdutoRepository clienteRepository)
        {
            _dev2BEntityDbContext = dev2BEntityDbContext;
            ProdutoRepository = clienteRepository;
        }

        public void Commit()
        {
            _dev2BEntityDbContext.SaveChanges();
        }
    }
}
