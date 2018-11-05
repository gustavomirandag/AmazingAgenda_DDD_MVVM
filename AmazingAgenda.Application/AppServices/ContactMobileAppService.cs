using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using AmazingAgenda.Application.ViewModels;
using AmazingAgenda.Application.ViewModels.Mobile;
using AmazingAgenda.Domain.Model.Entities;
using AmazingAgenda.Domain.Model.Interfaces.Services;
using AutoMapper;
using System.Linq;

namespace AmazingAgenda.Application.AppServices
{
    public class ContactMobileAppService : IContactAppService<ContactMobileViewModel>
    {
        private IContactService _contactService;

        public ObservableCollection<ContactMobileViewModel> ObservableContacts { get; }

        public ContactMobileAppService(IContactService contactService)
        {
            AutoMapper.AutoMapperConfig.RegisterMappings();
            _contactService = contactService;
            ObservableContacts = new ObservableCollection<ContactMobileViewModel>();
            var contacts = _contactService.GetAll();
            foreach(var contact in contacts)
            {
                ObservableContacts.Add(Mapper.Map<ContactMobileViewModel>(contact));
            }
        }

        public ContactMobileViewModel Add(ContactMobileViewModel contact)
        {
            Contact contactWithId = _contactService.Add(Mapper.Map<Contact>(contact));
            ContactMobileViewModel contactViewModel = Mapper.Map<ContactMobileViewModel>(contactWithId);
            ObservableContacts.Add(contactViewModel);
            return contactViewModel;
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
