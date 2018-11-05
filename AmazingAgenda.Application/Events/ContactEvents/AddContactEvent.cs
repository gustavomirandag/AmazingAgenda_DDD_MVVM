using AmazingAgenda.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingAgenda.Application.Events.ContactEvents
{
    public class AddContactEvent : ContactEvent
    {
        public AddContactEvent(Contact contact)
            :base(contact)
        {
        }
    }
}
