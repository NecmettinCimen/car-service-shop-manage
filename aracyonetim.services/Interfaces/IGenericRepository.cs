using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using aracyonetim.entities.Tables;

namespace aracyonetim.services.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<int> Save(T entity);
        Task<T> Get(int id);
        Task Update(T entity);
        Task Delete(int id);
        IQueryable<T> All();
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
    }
}