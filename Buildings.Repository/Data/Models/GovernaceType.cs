using System;
using System.Collections.Generic;
using Buildings.Domain.Data;
#nullable disable

namespace Buildings.Domain.Data.Models
{
    public partial class GovernaceType : IEntity
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
