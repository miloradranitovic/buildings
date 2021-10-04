using Buildings.Domain.Data;
using System;
using System.Collections.Generic;
#nullable disable

namespace Buildings.Domain.Data.Models
{
    public partial class User : IEntity
    {
        public User()
        {
            Invoices = new HashSet<Invoice>();
        }

        public Guid Id { get; set; }
        public string Username { get; set; }
        public bool? IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
