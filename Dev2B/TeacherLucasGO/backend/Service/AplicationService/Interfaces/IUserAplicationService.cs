using Commom.Dto.User;
using System.Threading.Tasks;

namespace Service.AplicationService.Interfaces
{
    public interface IUserAplicationService
    {
        Task<bool> Post(UserPostDto dto);
    }
}
