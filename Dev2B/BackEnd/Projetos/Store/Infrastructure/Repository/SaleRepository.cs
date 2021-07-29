using Domain;
using Infrastructure.Model;
using Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infrastructure.Repository
{
    public class SaleRepository : ISaleRepository
    {
        private readonly StoreDbContext _storeDbContext;

        public SaleRepository(StoreDbContext storeDbContext) => _storeDbContext = storeDbContext;

        #region get
        public IQueryable<Sale> Get() => _storeDbContext.Sales.AsNoTracking().Include(s => s.Customer).Include(s => s.Items).Include(s => s.Products);
        #endregion

        #region Post
        public void Post(Sale sale) => _storeDbContext.Sales.Add(sale);
        #endregion
    }
}
