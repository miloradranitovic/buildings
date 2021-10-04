using System;
using System.Collections.Generic;
using Buildings.Domain.Data;
#nullable disable

namespace Buildings.Domain.Data.Models
{
    public partial class InvoiceItemType : IEntity
    {
        public InvoiceItemType()
        {
            InvoiceItems = new HashSet<InvoiceItem>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}
