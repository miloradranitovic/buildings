using System;
using System.Collections.Generic;
using Buildings.Domain.Data;
#nullable disable

namespace Buildings.Domain.Data.Models
{
    public partial class BuildingSectionType : IEntity
    {
        public BuildingSectionType()
        {
            BuildingSections = new HashSet<BuildingSection>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<BuildingSection> BuildingSections { get; set; }
    }
}
