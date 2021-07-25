using System.Collections.Generic;
using System.Linq;
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
            var vendas = _dev2BEntityDbContext.Vendas.AsNoTracking()
                .Include(x => x.ListItensVenda)
                .Include(x => x.Cliente)
                .Include(x => x.ListItensVenda)
                .ThenInclude(x => x.Produto)
                .ToList();

            return vendas;
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
