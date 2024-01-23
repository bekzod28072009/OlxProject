using Microsoft.EntityFrameworkCore;
using Olx.Data.IRepositorys;
using Olx.Data.OlexDBContext;
using Olx.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Olx.Data.Repositorys
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Auditable
    {
        private readonly AppDBContext _DbContext;
        private readonly DbSet<T> dbSet;

        public GenericRepository()
        {
            _DbContext = new AppDBContext();
            dbSet = _DbContext.Set<T>();
        }
        public async ValueTask<T> CreateAsync(T entity) =>
             (await _DbContext.AddAsync(entity)).Entity;


        public async ValueTask<bool> DeleteAsync(Expression<Func<T, bool>> expression)
        {
            var entity = await GetAsync(expression);

            if (entity == null)
                return false;

            dbSet.Remove(entity);

            return true;
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression, string[] includes = null)
        {
            IQueryable<T> query = expression is null ? dbSet : dbSet.Where(expression);

            if (includes != null)
                foreach (var include in includes)
                    if (!string.IsNullOrEmpty(include))
                        query = query.Include(include);
            return query;
        }

        public async ValueTask<T> GetAsync(Expression<Func<T, bool>> expression, string[] includes = null) =>
            await dbSet.Where(expression).FirstOrDefaultAsync();

        public async ValueTask SaveChangesAsync() =>
           await _DbContext.SaveChangesAsync();

        public T Update(T entity) =>
            dbSet.Update(entity).Entity;

    }
}
