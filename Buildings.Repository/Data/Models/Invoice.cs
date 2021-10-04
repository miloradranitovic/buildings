using System;
using System.Collections.Generic;
using Buildings.Domain.Data;
#nullable disable

namespace Buildings.Domain.Data.Models
{
    public partial class Invoice : IEntity
    {
        public Invoice()
        {
            InvoiceItems = new HashSet<InvoiceItem>();
            Payments = new HashSet<Payment>();
        }

        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public string Title { get; set; }
        public Guid IssuerUserId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public Guid InvoiceStateId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Account Account { get; set; }
        public virtual InvoiceState InvoiceState { get; set; }
        public virtual User IssuerUser { get; set; }
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
