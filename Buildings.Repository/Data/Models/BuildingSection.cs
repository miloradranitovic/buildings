using System;
using System.Collections.Generic;
using Buildings.Domain.Data;
#nullable disable

namespace Buildings.Domain.Data.Models
{
    public partial class BuildingSection : IEntity
    {
        public BuildingSection()
        {
            BuildingSectionPayments = new HashSet<BuildingSectionPayment>();
        }

        public Guid Id { get; set; }
        public Guid BuildingId { get; set; }
        public Guid BuildingSectionTypeId { get; set; }
        public string Number { get; set; }
        public short SizeM2 { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public string OwnerEmail { get; set; }
        public string DifferentInvoiceAddress { get; set; }
        public bool Rented { get; set; }
        public short MembersCount { get; set; }

        public virtual Building Building { get; set; }
        public virtual BuildingSectionType BuildingSectionType { get; set; }
        public virtual ICollection<BuildingSectionPayment> BuildingSectionPayments { get; set; }
    }
}
