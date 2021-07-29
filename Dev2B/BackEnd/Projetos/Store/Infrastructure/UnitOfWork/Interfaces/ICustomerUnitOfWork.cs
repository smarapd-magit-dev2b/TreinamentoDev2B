using Infrastructure.Repository.Interfaces;

namespace Infrastructure.UnitOfWork.Interfaces
{
    public interface ICustomerUnitOfWork
    {
        ICustomerRepository CustomerRepository { get; }
        void Commit();
    }
}
