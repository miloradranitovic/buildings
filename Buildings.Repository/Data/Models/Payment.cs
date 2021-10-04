using System;
using System.Collections.Generic;
using Buildings.Domain.Data;
#nullable disable

namespace Buildings.Domain.Data.Models
{
    public partial class Payment : IEntity
    {
        public Payment()
        {
            BuildingOutcomes = new HashSet<BuildingOutcome>();
        }

        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public Guid InvoiceId { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual ICollection<BuildingOutcome> BuildingOutcomes { get; set; }
    }
}
