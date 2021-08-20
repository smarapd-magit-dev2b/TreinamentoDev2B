using Domain;
using Infrastructure.Repository.Interfaces;

namespace Infrastructure.UnitOfWork.Interfaces
{
    public interface IUserUnitOfWork
    {
        IRepository<User> UserRepository { get; set; }
    }
}
