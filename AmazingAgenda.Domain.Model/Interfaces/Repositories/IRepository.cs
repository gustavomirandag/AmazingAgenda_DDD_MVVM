using AmazingAgenda.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingAgenda.Domain.Model.Interfaces.Repositories
{
    public interface IRepository<TEntity,TId> where TEntity : EntityBase<TId>
    {
        TEntity Add(TEntity entity);
        TEntity GetById(TId id);
        IEnumerable<TEntity> GetAll();
        void Remove(TId id);
        TEntity Update(TEntity entity);
    }
}
