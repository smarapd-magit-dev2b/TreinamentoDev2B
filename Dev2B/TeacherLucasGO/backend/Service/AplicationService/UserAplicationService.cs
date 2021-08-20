using Commom.Dto.User;
using Commom.Exceptions.User;
using Domain;
using Infrastructure.UnitOfWork.Interfaces;
using Microsoft.EntityFrameworkCore;
using Service.AplicationService.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace Service.AplicationService
{
    public class UserAplicationService : IUserAplicationService
    {
        private readonly IUserUnitOfWork _uow;

        public UserAplicationService(IUserUnitOfWork uow) => _uow = uow;

        public async Task<bool> Post(UserPostDto dto)
        {
            User user = await _uow.UserRepository.GetUntracked()
                .Select(user => new User()
                {
                    Username = user.Username,
                    Password = user.Password,
                    Status = user.Status
                })
                .FirstOrDefaultAsync(user => user.Username == dto.Username);

            Validate(user, dto);

            return true;
        }

        private void Validate(User user, UserPostDto dto)
        {
            if (user == null)
                throw new UserUnauthorizedException("wrong user");

            if (user.Password != dto.Password)
                throw new UserUnauthorizedException("incorrect password");

            if (!user.Status)
                throw new UserForbiddenException("inactive user");
        }
    }
}
