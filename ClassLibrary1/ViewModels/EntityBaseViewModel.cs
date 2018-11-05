using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingAgenda.Application.ViewModels
{
    public abstract class EntityBaseViewModel<TId>
    {
        public TId Id { get; set; }
    }
}
