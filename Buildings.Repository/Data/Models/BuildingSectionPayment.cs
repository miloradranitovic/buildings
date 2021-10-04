using System;
using System.Collections.Generic;
using Buildings.Domain.Data;
#nullable disable

namespace Buildings.Domain.Data.Models
{
    public partial class BuildingSectionPayment : IEntity
    {
        public Guid Id { get; set; }
        public Guid? BuildingSectionId { get; set; }
        public Guid? PaymentId { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual BuildingSection BuildingSection { get; set; }
    }
}
