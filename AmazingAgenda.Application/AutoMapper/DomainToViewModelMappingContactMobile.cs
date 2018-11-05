using AmazingAgenda.Application.ViewModels;
using AmazingAgenda.Application.ViewModels.Mobile;
using AmazingAgenda.Domain.Model.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingAgenda.Application.AutoMapper
{
    public class DomainToViewModelMappingContactMobile : Profile
    {
        public DomainToViewModelMappingContactMobile()
        {
            CreateMap<Contact, ContactMobileViewModel>();
        }
    }
}
