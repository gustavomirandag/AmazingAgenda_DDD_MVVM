using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingAgenda.Infrastructure.Factories
{
    public interface IIdFactory<TId>
    {
        TId GenerateId();
    }
}
