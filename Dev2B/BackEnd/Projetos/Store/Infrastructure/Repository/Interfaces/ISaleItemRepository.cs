using Domain;

namespace Infrastructure.Repository.Interfaces
{
    public interface ISaleItemRepository
    {
        SaleItem Get(int id);
        void Post(SaleItem saleItem);
    }
}
