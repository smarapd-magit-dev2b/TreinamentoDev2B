using Domain;
using Infrastructure.Model;
using Infrastructure.Repository.Interfaces;
using Infrastructure.UnitOfWork.Interfaces;
using System.Threading.Tasks;

namespace Infrastructure.UnitOfWork
{
    public class TeacherUnitOfWork : ITeacherUnitOfWork
    {
        private readonly TeacherLucasGODbContext _dbContext;
        public IRepository<Teacher> TeacherRepository { get; set; }
        public IRepository<Address> AddressRepository { get; set; }
        public IRepository<Discipline> DisciplineRepository { get; set; }

        public TeacherUnitOfWork(TeacherLucasGODbContext dbContext,
                                 IRepository<Teacher> teacherRepository,
                                 IRepository<Address> addressRepository,
                                 IRepository<Discipline> disciplineRepository)
        {
            _dbContext = dbContext;
            TeacherRepository = teacherRepository;
            AddressRepository = addressRepository;
            DisciplineRepository = disciplineRepository;
        }

        public async Task Commit() => await _dbContext.SaveChangesAsync();
    }
}
