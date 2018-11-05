using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingAgenda.Domain.Model.Interfaces.Services
{
    //CASOS DE USO
    public interface IService<TEntity,TId>
    {
        TEntity Add(TEntity entity);
        TEntity GetById(TId id);
        IEnumerable<TEntity> GetAll();
        void Remove(TId id);
        TEntity Update(TEntity entity);
    }
}
