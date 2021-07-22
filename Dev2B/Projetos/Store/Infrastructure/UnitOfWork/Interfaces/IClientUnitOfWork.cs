using Infrastructure.Repository.Interfaces;

namespace Infrastructure.UnitOfWork.Interfaces
{
    public interface ICostummerUnitOfWork
    {
        ICostummerRepository CostummerRepository { get; }
        void Commit();
    }
}
