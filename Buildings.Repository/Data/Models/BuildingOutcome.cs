using Buildings.Domain.Data;
using System;
using Buildings.Domain.Data;
#nullable disable

namespace Buildings.Domain.Data.Models
{
    public partial class BuildingOutcome : IEntity
    {
        public Guid Id { get; set; }
        public Guid BuildingId { get; set; }
        public Guid PaymentId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Building Building { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
