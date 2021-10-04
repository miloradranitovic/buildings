using Buildings.Domain.Data;
using System;
using System.Collections.Generic;
#nullable disable

namespace Buildings.Domain.Data.Models
{
    public partial class Building : IEntity
    {
        public Building()
        {
            BuildingOutcomes = new HashSet<BuildingOutcome>();
            BuildingSections = new HashSet<BuildingSection>();
        }

        public Guid Id { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string PostNumber { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string TaxNumber { get; set; }
        public string PersonalNumber { get; set; }
        public Guid AccountId { get; set; }
        public bool HasElevator { get; set; }
        public short ConstructionYear { get; set; }
        public Guid GovernanceTypeId { get; set; }
        public string Email { get; set; }

        public virtual ICollection<BuildingOutcome> BuildingOutcomes { get; set; }
        public virtual ICollection<BuildingSection> BuildingSections { get; set; }
    }
}
