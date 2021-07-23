using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Entities;
using Infrasctruture.Model;
using Microsoft.EntityFrameworkCore;

namespace Infrasctruture.Repository.Interfaces
{
    public class VendaRepository : IVendaRepository
    {
        private readonly Dev2bEntityDbContext _dev2BEntityDbContext;

        public VendaRepository(Dev2bEntityDbContext dev2BEntityDbContext)
        {
            _dev2BEntityDbContext = dev2BEntityDbContext;
        }

        public IEnumerable<Venda> GetAll()
        {
            return _dev2BEntityDbContext.Vendas.AsNoTracking().ToList();
        }

        public Venda GetById(int id)
        {
            return _dev2BEntityDbContext.Vendas.FirstOrDefault(x => x.Id == id);
        }

        public void Post(Venda venda)
        {
            _dev2BEntityDbContext.Vendas.Add(venda);
        }
    }
}
