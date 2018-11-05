using AmazingAgenda.Domain.Model.Entities;
using AmazingAgenda.Domain.Model.Interfaces.Repositories;
using AmazingAgenda.Domain.Model.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingAgenda.Domain.Service.Services
{
    public abstract class ServiceBase<TEntity, TId> : IService<TEntity, TId> where TEntity : EntityBase<TId>
    {
        private readonly IRepository<TEntity,TId> _repository;

        protected ServiceBase(IRepository<TEntity, TId> repository)
        {
            _repository = repository;
        }

        public TEntity Add(TEntity entity)
        {
            return _repository.Add(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(TId id)
        {
            return _repository.GetById(id);
        }

        public void Remove(TId id)
        {
            _repository.Remove(id);
        }

        public TEntity Update(TEntity entity)
        {
            return _repository.Update(entity);
        }
    }
}
