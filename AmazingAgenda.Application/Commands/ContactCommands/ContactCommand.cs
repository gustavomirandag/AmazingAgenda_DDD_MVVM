using AmazingAgenda.Application.ViewModels;
using AmazingAgenda.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingAgenda.Application.Commands.ContactCommands
{
    public abstract class ContactCommand
    {
        public Contact Contact { get; set; }

        protected ContactCommand(Contact contact)
        {
            Contact = contact;
        }
    }
}
