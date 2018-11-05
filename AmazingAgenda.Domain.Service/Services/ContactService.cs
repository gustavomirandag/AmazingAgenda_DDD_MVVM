using AmazingAgenda.Domain.Model.Entities;
using AmazingAgenda.Domain.Model.Interfaces.Repositories;
using AmazingAgenda.Domain.Model.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingAgenda.Domain.Service.Services
{
    public class ContactService : ServiceBase<Contact,Guid>, IContactService
    {
        public ContactService(IContactRepository contactRepository)
            :base(contactRepository)
        {
        }
    }

}
