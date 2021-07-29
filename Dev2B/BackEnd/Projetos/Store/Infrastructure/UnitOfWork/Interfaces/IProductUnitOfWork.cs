using Infrastructure.Repository.Interfaces;

namespace Infrastructure.UnitOfWork.Interfaces
{
    public interface IProductUnitOfWork
    {
        IProductRepository ProductRepository { get; set; }
        void Commit();
    }
}
