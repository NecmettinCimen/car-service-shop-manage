using aracyonetim.database;
using aracyonetim.entities.Tables;
using aracyonetim.services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace aracyonetim.services.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly AracYonetimContext _dbContext;
        private readonly DbSet<T> _dbSet;

        protected GenericRepository(AracYonetimContext dbContext)
        {
            this._dbContext = dbContext;
            this._dbSet = _dbContext.Set<T>();
        }

        public async Task<int> Save(T entity)
        {
            entity.CreateDate = DateTime.Now;
            await _dbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<T> Get(int id, int firmaid)
        {
            return await _dbSet.Where(w => w.FirmaId == firmaid).FirstAsync(f => f.Id == id);
        }

        public async Task Update(T entity)
        {
            entity.IsDeleted = false;
            entity.CreateDate = DateTime.Now;
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id, int firmaid)
        {
            var entity = await Get(id, firmaid);
            entity.IsDeleted = true;
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public IQueryable<T> All()
        {
            return _dbSet.AsNoTracking().Where(w => !w.IsDeleted).OrderByDescending(o => o.Id);
        }
        public IQueryable<T> All(int id)
        {
            return _dbSet.AsNoTracking().Where(w => !w.IsDeleted && w.FirmaId == id).OrderByDescending(o => o.Id);
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(w => !w.IsDeleted).Where(predicate);
        }

        public async Task<List<T>> FromSql(string sql)
        {
            return await _dbSet.FromSqlRaw(sql).ToListAsync();
        }
    }
}