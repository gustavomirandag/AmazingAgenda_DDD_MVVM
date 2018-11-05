using AmazingAgenda.Application.ViewModels;
using AmazingAgenda.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingAgenda.Application.Commands.ContactCommands
{
    public class UpdateContactCommand : ContactCommand
    {
        public UpdateContactCommand(Contact contact)
            : base(contact)
        {
        }
    }
}
