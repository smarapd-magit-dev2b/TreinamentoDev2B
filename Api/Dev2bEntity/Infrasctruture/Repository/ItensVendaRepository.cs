using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Infrasctruture.Model;
using Infrasctruture.Repository.Interfaces;

namespace Infrasctruture.Repository
{
    public class ItensVendaRepository : IItensVendaRepository
    {
        private readonly Dev2bEntityDbContext _dev2BEntityDbContext;

        public ItensVendaRepository(Dev2bEntityDbContext dev2BEntityDbContext)
        {
            _dev2BEntityDbContext = dev2BEntityDbContext;
        }

        public void Post(ItensVenda itensVenda)
        {
            _dev2BEntityDbContext.ItensVenda.Add(itensVenda);
        }
    }
}
