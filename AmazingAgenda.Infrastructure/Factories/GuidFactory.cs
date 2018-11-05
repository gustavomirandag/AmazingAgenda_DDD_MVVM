using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingAgenda.Infrastructure.Factories
{
    public class GuidFactory : IIdFactory<Guid>
    {
        public Guid GenerateId()
        {
            return Guid.NewGuid();
        }
    }
}
