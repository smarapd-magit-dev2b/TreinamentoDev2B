using Infrastructure.Repository.Interfaces;

namespace Infrastructure.UnitOfWork.Interfaces
{
    public interface IPersonUnitOfWork
    {
        public IPersonRepository PersonRepository { get; }
    }
}
