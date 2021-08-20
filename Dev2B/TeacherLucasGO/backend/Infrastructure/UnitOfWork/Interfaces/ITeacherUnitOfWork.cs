using Domain;
using Infrastructure.Repository.Interfaces;
using System.Threading.Tasks;

namespace Infrastructure.UnitOfWork.Interfaces
{
    public interface ITeacherUnitOfWork
    {
        IRepository<Teacher> TeacherRepository { get; set; }
        IRepository<Address> AddressRepository { get; set; }
        IRepository<Discipline> DisciplineRepository { get; set; }

        Task Commit();
    }
}
