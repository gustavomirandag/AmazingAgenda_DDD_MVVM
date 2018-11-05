using AmazingAgenda.Domain.Model.Entities;
using AmazingAgenda.Domain.Model.Interfaces.Repositories;
using AmazingAgenda.Infrastructure.Factories;
using System;
using System.Collections.Generic;
using System.Text;
using AmazingAgenda.Infrastructure.Extensions;

namespace AmazingAgenda.Infrastructure.Repositories
{
    public class ContactRamRepository : RepositoryBase<Contact, Guid>, IContactRepository
    {
        private static readonly ICollection<Contact> _contacts = new List<Contact>();

        public ContactRamRepository()
            :base(_contacts,new GuidFactory())
        {

        }

        public override Contact Update(Contact entity)
        {
            Contact originalContact = GetById(entity.Id);
            originalContact.CopyPropertiesFrom(entity);
            return originalContact;
        }
    }
}
