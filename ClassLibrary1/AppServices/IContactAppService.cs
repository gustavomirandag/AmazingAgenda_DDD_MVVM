using AmazingAgenda.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingAgenda.Application.AppServices
{
    public interface IContactAppService<TContactViewModel>
    {
        TContactViewModel Add(TContactViewModel contact);
        TContactViewModel GetById(Guid id);
        IEnumerable<TContactViewModel> GetAll();
        void Remove(Guid id);
        TContactViewModel Update(TContactViewModel contact);
    }
}
