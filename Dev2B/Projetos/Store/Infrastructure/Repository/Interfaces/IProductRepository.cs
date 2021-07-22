using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> Get();
        Product Get(int id);
        void Post(Product product);
        void Put(Product product);
        void Delete(Product product);
    }
}
