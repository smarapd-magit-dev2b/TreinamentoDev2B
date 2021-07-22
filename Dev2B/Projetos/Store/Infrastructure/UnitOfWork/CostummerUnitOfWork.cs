using Infrastructure.Model;
using Infrastructure.Repository.Interfaces;
using Infrastructure.UnitOfWork.Interfaces;

namespace Infrastructure.UnitOfWork
{
    public class CostummerUnitOfWork : ICostummerUnitOfWork
    {
        private readonly StoreDbContext _storeDbContext;
        public ICostummerRepository CostummerRepository { get; }

        public CostummerUnitOfWork(StoreDbContext storeDbContext, ICostummerRepository costumerRepository)
        {
            _storeDbContext = storeDbContext;
            CostummerRepository = costumerRepository;
        }

        public void Commit() => _storeDbContext.SaveChanges();
    }
}
