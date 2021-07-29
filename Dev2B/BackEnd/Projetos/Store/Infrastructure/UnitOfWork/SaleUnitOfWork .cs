using Infrastructure.Model;
using Infrastructure.Repository.Interfaces;
using Infrastructure.UnitOfWork.Interfaces;

namespace Infrastructure.UnitOfWork
{
    public class SaleUnitOfWork : ISaleUnitOfWork
    {
        private readonly StoreDbContext _storeDbContext;
        public ISaleRepository SaleRepository { get; set; }
        public ICustomerRepository CustomerRepository { get; set; }
        public IProductRepository ProductRepository { get; set; }

        public SaleUnitOfWork(StoreDbContext storeDbContext,
                              ICustomerRepository customerRepository,
                              ISaleRepository saleRepository,
                              IProductRepository productRepository)
        {
            _storeDbContext = storeDbContext;
            CustomerRepository = customerRepository;
            SaleRepository = saleRepository;
            ProductRepository = productRepository;
        }

        public void Commit() => _storeDbContext.SaveChanges();
    }
}
