using Domain;
using System.Linq;

namespace Infrastructure.Repository.Interfaces
{
    public interface IProductRepository
    {
        IQueryable<Product> Get();
        Product Get(int id);
        void Post(Product product);
        void Put(Product product);
        void Delete(Product product);
    }
}
