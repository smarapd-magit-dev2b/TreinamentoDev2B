using System;
using System.Collections.Generic;
using System.Text;
using Infrasctruture.Model;
using Infrasctruture.Repository.Interfaces;
using Infrasctruture.UnitOfWork.Interfaces;

namespace Infrasctruture.UnitOfWork
{
    public class ClienteUnitOfWork : IClienteUnitOfWork
    {
        private readonly Dev2bEntityDbContext _dev2BEntityDbContext;
        public IClienteRepository ClienteRepository { get; }

        public ClienteUnitOfWork(Dev2bEntityDbContext dev2BEntityDbContext, IClienteRepository clienteRepository)
        {
            _dev2BEntityDbContext = dev2BEntityDbContext;
            ClienteRepository = clienteRepository;
        }

        public void Commit()
        {
            _dev2BEntityDbContext.SaveChanges();
        }
    }
}
