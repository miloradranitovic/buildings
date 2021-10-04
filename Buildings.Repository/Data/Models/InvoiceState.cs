using System;
using System.Collections.Generic;
using Buildings.Domain.Data;
#nullable disable

namespace Buildings.Domain.Data.Models
{
    public partial class InvoiceState : IEntity
    {
        public InvoiceState()
        {
            Invoices = new HashSet<Invoice>();
        }

        public Guid Id { get; set; }
        public string State { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
