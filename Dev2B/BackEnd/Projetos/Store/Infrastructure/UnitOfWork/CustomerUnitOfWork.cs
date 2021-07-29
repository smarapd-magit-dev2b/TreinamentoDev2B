using Infrastructure.Model;
using Infrastructure.Repository.Interfaces;
using Infrastructure.UnitOfWork.Interfaces;

namespace Infrastructure.UnitOfWork
{
    public class CustomerUnitOfWork : ICustomerUnitOfWork
    {
        private readonly StoreDbContext _storeDbContext;
        public ICustomerRepository CustomerRepository { get; }

        public CustomerUnitOfWork(StoreDbContext storeDbContext, ICustomerRepository customerRepository)
        {
            _storeDbContext = storeDbContext;
            CustomerRepository = customerRepository;
        }

        public void Commit() => _storeDbContext.SaveChanges();
    }
}
