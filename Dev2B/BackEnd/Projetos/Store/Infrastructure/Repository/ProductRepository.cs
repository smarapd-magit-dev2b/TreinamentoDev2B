using Domain;
using Infrastructure.Model;
using Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreDbContext _storeDbContext;

        public ProductRepository(StoreDbContext storeDbContext) => _storeDbContext = storeDbContext;

        #region Get
        public IQueryable<Product> Get() => _storeDbContext.Products.AsNoTracking();

        public Product Get(int id) => _storeDbContext.Products.AsNoTracking().FirstOrDefault(p => p.Id == id);
        #endregion

        #region Post
        public void Post(Product product) => _storeDbContext.Products.Add(product);
        #endregion

        #region Put
        public void Put(Product product) => _storeDbContext.Products.Update(product);
        #endregion

        #region Delete
        public void Delete(Product product) => _storeDbContext.Products.Remove(product);
        #endregion
    }
}
