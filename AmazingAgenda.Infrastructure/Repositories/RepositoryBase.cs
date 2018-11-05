using AmazingAgenda.Domain.Model.Entities;
using AmazingAgenda.Domain.Model.Interfaces.Repositories;
using AmazingAgenda.Infrastructure.Factories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AmazingAgenda.Infrastructure.Repositories
{
    public abstract class RepositoryBase<TEntity, TId> : IRepository<TEntity, TId> where TEntity : EntityBase<TId>
    {
        private readonly ICollection<TEntity> _collection;
        private readonly IIdFactory<TId> _idFactory;

        protected RepositoryBase(ICollection<TEntity> collection, IIdFactory<TId> idFactory)
        {
            _collection = collection;
            _idFactory = idFactory;
        }

        public TEntity Add(TEntity entity)
        {
            entity.Id = _idFactory.GenerateId();
            _collection.Add(entity);
            return GetById(entity.Id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _collection;
        }

        public virtual TEntity GetById(TId id)
        {
            return _collection.Single(e => e.Id.Equals(id));
        }

        public void Remove(TId id)
        {
            _collection.Remove(GetById(id));
        }

        public abstract TEntity Update(TEntity entity);
    }
}
