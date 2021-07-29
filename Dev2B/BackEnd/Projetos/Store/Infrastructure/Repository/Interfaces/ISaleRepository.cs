using Domain;
using System.Linq;

namespace Infrastructure.Repository.Interfaces
{
    public interface ISaleRepository
    {
        IQueryable<Sale> Get();
        void Post(Sale sale);
    }
}
