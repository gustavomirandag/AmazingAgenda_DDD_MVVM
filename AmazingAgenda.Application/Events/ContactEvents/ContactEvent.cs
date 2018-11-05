using AmazingAgenda.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingAgenda.Application.Events.ContactEvents
{
    public abstract class ContactEvent
    {
        public Contact Contact { get; set; }

        protected ContactEvent(Contact contact)
        {
            Contact = contact;
        }
    }
}
