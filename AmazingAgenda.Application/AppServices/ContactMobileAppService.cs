﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using AmazingAgenda.Application.ViewModels;
using AmazingAgenda.Application.ViewModels.Mobile;
using AmazingAgenda.Domain.Model.Entities;
using AmazingAgenda.Domain.Model.Interfaces.Services;
using AutoMapper;
using System.Linq;
using AmazingAgenda.Application.Commands.ContactCommands;
using AmazingAgenda.Application.CommandHandlers;

namespace AmazingAgenda.Application.AppServices
{
    public class ContactMobileAppService : IContactAppService<ContactMobileViewModel>
    {
        private IContactService _contactService;
        private ContactCommandHandler _contactCommandHandler;
        public ObservableCollection<ContactMobileViewModel> ObservableContacts { get; }

        public ContactMobileAppService(IContactService contactService)
        {
            AutoMapper.AutoMapperConfig.RegisterMappings();
            ObservableContacts = new ObservableCollection<ContactMobileViewModel>();
            _contactService = contactService;
            _contactCommandHandler = new ContactCommandHandler(contactService, this);
            var contacts = _contactService.GetAll();
            foreach(var contact in contacts)
            {
                ObservableContacts.Add(Mapper.Map<ContactMobileViewModel>(contact));
            }
        }

        public void Add(ContactMobileViewModel contact)
        {
            _contactCommandHandler.ProcessQueue(new AddContactCommand(Mapper.Map<Contact>(contact)));
        }

        public IEnumerable<ContactMobileViewModel> GetAll()
        {
            return ObservableContacts;
        }

        public ContactMobileViewModel GetById(Guid id)
        {
            return Mapper.Map<ContactMobileViewModel>(_contactService.GetById(id));
        }

        public void Remove(Guid id)
        {
            _contactService.Remove(id);
            ContactMobileViewModel contactViewModel = ObservableContacts.Single(c => c.Id == id);
            ObservableContacts.Remove(contactViewModel);
        }

        public ContactMobileViewModel Update(ContactMobileViewModel contact)
        {
            Contact deletedContact = _contactService.Update(Mapper.Map<Contact>(contact));
            return Mapper.Map<ContactMobileViewModel>(deletedContact);
        }
    }
}
