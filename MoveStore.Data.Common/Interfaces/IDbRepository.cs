using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MoveStore.Data.Common.Interfaces
{
    public interface IDbRepository<T> where T:IEntity
    {
        IEnumerable<T> List { get; }
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T FindById(Guid Id);
        IQueryable<T> GetQuery();
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);
        T FirstOrDefault(Expression<Func<T, bool>> predicate);
    }
}
