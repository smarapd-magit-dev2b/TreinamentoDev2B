using Infrastructure.Repository.Interfaces;

namespace Infrastructure.UnitOfWork.Interfaces
{
    public interface ISaleUnitOfWork
    {
        ISaleRepository SaleRepository { get; set; }
        ICustomerRepository CustomerRepository { get; set; }
        IProductRepository ProductRepository { get; set; }
        void Commit();
    }
}
