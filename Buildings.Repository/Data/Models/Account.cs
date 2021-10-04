using System;
using System.Collections.Generic;
using Buildings.Domain.Data;
#nullable disable

namespace Buildings.Domain.Data.Models
{
    public partial class Account : IEntity
    {
        public Account()
        {
            Invoices = new HashSet<Invoice>();
            Partners = new HashSet<Partner>();
        }

        public Guid Id { get; set; }
        public string Number { get; set; }
        public decimal Balance { get; set; }
        public decimal StartingBalance { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Partner> Partners { get; set; }
    }
}
