using Domain;
using Infrastructure.Model;
using Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infrastructure.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly StoreDbContext _storeDbContext;

        public CustomerRepository(StoreDbContext storeDbContext) => _storeDbContext = storeDbContext;

        #region Get
        public IQueryable<Customer> Get() => _storeDbContext.Customers.AsNoTracking();

        public Customer Get(int id) => _storeDbContext.Customers.AsNoTracking().FirstOrDefault(c => c.Id == id);
        #endregion

        #region Post
        public void Post(Customer customer) => _storeDbContext.Customers.Add(customer);
        #endregion

        #region Put
        public void Put(Customer customer) => _storeDbContext.Customers.Update(customer);
        #endregion

        #region Delete
        public void Delete(Customer customer) => _storeDbContext.Customers.Remove(customer);
        #endregion
    }
}
