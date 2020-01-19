using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using aracyonetim.entities.Dtos;
using aracyonetim.entities.Tables;

namespace aracyonetim.services.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<int> Save(T entity);
        Task<T> Get(int id, int firmaid);
        Task Update(T entity);
        Task Delete(int id, int firmaid);
        IQueryable<T> All();
        IQueryable<T> All(int id);
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        public Task<List<T>> FromSql(string sql);
    }
}