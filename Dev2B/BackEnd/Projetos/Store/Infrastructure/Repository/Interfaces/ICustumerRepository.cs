using Domain;
using System.Linq;

namespace Infrastructure.Repository.Interfaces
{
    public interface ICustomerRepository
    {
        IQueryable<Customer> Get();
        Customer Get(int id);
        void Post(Customer customer);
        void Put(Customer customer);
        void Delete(Customer customer);
    }
}
