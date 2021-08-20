using Infrastructure.Model;
using Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbSet<TEntity> _table;

        public Repository(TeacherLucasGODbContext dbContext) => _table = dbContext.Set<TEntity>();

        public IQueryable<TEntity> GetUntracked() => _table.AsNoTracking();

        public IQueryable<TEntity> GetTracked() => _table;

        public async Task Post(TEntity entity) => await _table.AddAsync(entity);

        public void Delete(TEntity entity) => _table.Remove(entity);
    }
}
