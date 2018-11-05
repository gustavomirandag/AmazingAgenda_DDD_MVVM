using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingAgenda.Application.ViewModels
{
    public abstract class ContactViewModel : EntityBaseViewModel<Guid>
    {
        public virtual string Name { get; set; }
        public virtual DateTime Birth { get; set; }
        public virtual string Email { get; set; }
        public virtual string Phone { get; set; }
    }
}
