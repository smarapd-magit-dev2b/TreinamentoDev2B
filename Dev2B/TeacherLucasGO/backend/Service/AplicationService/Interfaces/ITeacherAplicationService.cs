using Commom.Dto.Teacher;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.AplicationService.Interfaces
{
    public interface ITeacherAplicationService
    {
        IEnumerable<TeacherGetDto> GetAll();
        Task<int> Post(TeacherPostDto dto);
        Task Put(int id, TeacherPutDto dto);
        Task Delete(int id);
    }
}
