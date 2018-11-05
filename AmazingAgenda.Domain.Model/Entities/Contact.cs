using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingAgenda.Domain.Model.Entities
{
    public class Contact : EntityBase<Guid>
    {
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Contact()
        {
            Name = string.Empty;
            Birth = DateTime.Now;
            Email = string.Empty;
            Phone = string.Empty;
        }
    }
}
