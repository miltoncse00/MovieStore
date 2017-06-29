using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using MoveStore.Data.Common.Interfaces;

namespace MovieStore.Data.EntityF.DbManager
{
    public class DbRepository<T> : IDbRepository<T> where T : class, IEntity
    {
        private readonly DbSet<T> _dbSet;

        public DbRepository(DbSet<T> dbSet)
        {
            _dbSet = dbSet;
        }

        public IEnumerable<T> List => _dbSet.AsQueryable().ToList();

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
        }

        public T FindById(Guid Id)
        {
            return _dbSet.AsQueryable().FirstOrDefault(s => s.Id == Id);
        }

        public IQueryable<T> GetQuery()
        {
            return _dbSet.AsQueryable();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.FirstOrDefault(predicate);
        }
    }
}
