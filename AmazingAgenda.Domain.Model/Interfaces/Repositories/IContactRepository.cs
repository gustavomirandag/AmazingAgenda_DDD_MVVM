using AmazingAgenda.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingAgenda.Domain.Model.Interfaces.Repositories
{
    public interface IContactRepository : IRepository<Contact,Guid>
    {
    }
}
