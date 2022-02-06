using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DapperContribDemo.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity>
    {
        TEntity GetById(int Id);
        IEnumerable<TEntity> GetAll();
        long Save(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(int id);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> filter);
    }
}
