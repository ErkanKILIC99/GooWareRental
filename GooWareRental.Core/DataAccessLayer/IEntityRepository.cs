using GooWareRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GooWareRental.Core.DataAccessLayer
{
    public interface IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        bool Insert(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
    }
}
