using Infrastructure.Model;
using Infrastructure.Repository.Interfaces;
using Infrastructure.UnitOfWork.Interfaces;

namespace Infrastructure.UnitOfWork
{
    public class ProductUnitOfWork : IProductUnitOfWork
    {
        private readonly StoreDbContext _storeDbContext;
        public IProductRepository ProductRepository { get; set; }

        public ProductUnitOfWork(StoreDbContext storeDbContext, IProductRepository productRepository)
        {
            _storeDbContext = storeDbContext;
            ProductRepository = productRepository;
        }

        public void Commit() => _storeDbContext.SaveChanges();
    }
}
