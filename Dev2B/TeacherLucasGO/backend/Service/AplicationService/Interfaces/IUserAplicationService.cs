using Commom.Dto.User;
using System.Collections.Generic;

namespace Service.AplicationService.Interfaces
{
    public interface IUserAplicationService
    {
        IEnumerable<UserDtoGet> GetAll();
    }
}
