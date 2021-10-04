using System;
using System.Collections.Generic;
using Buildings.Domain.Data;
#nullable disable

namespace Buildings.Domain.Data.Models
{
    public partial class Partner : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string WorkArea { get; set; }
        public string TaxNumber { get; set; }
        public string PersonalNumber { get; set; }
        public Guid AccountId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Account Account { get; set; }
    }
}
