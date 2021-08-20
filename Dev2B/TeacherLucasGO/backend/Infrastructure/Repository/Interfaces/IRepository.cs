using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetUntracked();
        IQueryable<TEntity> GetTracked();
        Task Post(TEntity entity);
        void Delete(TEntity entity);
    }
}
