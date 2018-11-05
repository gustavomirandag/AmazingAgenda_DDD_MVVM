using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingAgenda.Application.AutoMapper
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingContactMobile>();
                x.AddProfile<ViewModelToDomainMappingContactMobile>();
            });
        }
    }
}
