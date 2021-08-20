using Domain;
using Infrastructure.Repository.Interfaces;
using Infrastructure.UnitOfWork.Interfaces;

namespace Infrastructure.UnitOfWork
{
    public class UserUnitOfWork : IUserUnitOfWork
    {
        public IRepository<User> UserRepository { get; set; }

        public UserUnitOfWork(IRepository<User> userRepository) => UserRepository = userRepository;
    }
}
