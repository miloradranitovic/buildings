using System;
using System.Collections.Generic;
using Buildings.Domain.Data;
#nullable disable

namespace Buildings.Domain.Data.Models
{
    public partial class InvoiceItem : IEntity
    {
        public Guid Id { get; set; }
        public Guid InvoiceId { get; set; }
        public decimal Amount { get; set; }
        public Guid InvoiceItemTypeId { get; set; }
        public string Comment { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual InvoiceItemType InvoiceItemType { get; set; }
    }
}
