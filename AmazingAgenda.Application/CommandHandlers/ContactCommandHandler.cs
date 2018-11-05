using AmazingAgenda.Application.AppServices;
using AmazingAgenda.Application.Commands.ContactCommands;
using AmazingAgenda.Application.Events.ContactEvents;
using AmazingAgenda.Application.ViewModels.Mobile;
using AmazingAgenda.Domain.Model.Entities;
using AmazingAgenda.Domain.Model.Interfaces.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingAgenda.Application.CommandHandlers
{
    public class ContactCommandHandler
    {
        private Queue<ContactCommand> _contactCommands = new Queue<ContactCommand>();
        private Queue<ContactEvent> _contactEvents = new Queue<ContactEvent>();
        private IContactService _contactService;
        private ContactMobileAppService _contactMobileAppService;

        public ContactCommandHandler(IContactService contactService, ContactMobileAppService contactMobileAppService)
        {
            _contactService = contactService;
            _contactMobileAppService = contactMobileAppService;
        }

        public void ProcessQueue(ContactCommand contactCommand)
        {
            _contactCommands.Enqueue(contactCommand);
            while(_contactCommands.Count > 0)
            {
                ContactCommand command = _contactCommands.Dequeue();
                if (command is AddContactCommand)
                    AddContact(command);
            }
        }

        private void AddContact(ContactCommand contactCommand)
        {
            Contact contactWithId = _contactService.Add(Mapper.Map<Contact>(contactCommand.Contact));
            ContactMobileViewModel contactViewModel = Mapper.Map<ContactMobileViewModel>(contactWithId);
            _contactMobileAppService.ObservableContacts.Add(contactViewModel);
            _contactEvents.Enqueue(new AddContactEvent(contactWithId));
        }
    }
}
