using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildings.Model.Dto
{
    public class BuildingDto
    {
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
    }
}
