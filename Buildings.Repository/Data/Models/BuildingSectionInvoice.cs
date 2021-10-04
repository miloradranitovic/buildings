using System;
using System.Collections.Generic;
using Buildings.Domain.Data;
#nullable disable

namespace Buildings.Domain.Data.Models
{
    public partial class BuildingSectionInvoice : IEntity
    {
        public Guid Id { get; set; }
        public Guid? BuildingSectionId { get; set; }
        public Guid? InvoiceId { get; set; }
    }
}
