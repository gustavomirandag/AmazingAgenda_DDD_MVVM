using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingAgenda.Domain.Model.Entities
{
    public abstract class EntityBase<T>
    {
        public T Id { get; set; }
    }
}
