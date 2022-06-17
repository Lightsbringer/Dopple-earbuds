using System;
using System.Collections.Generic;
using WebApplication3.Models;
using static WebApplication3.Models.UserPage;

#nullable disable

namespace WebApplication3.APIDTOs
{
    public partial class StationEntity
    {
        public StationEntity()
        {
            Carriers = new HashSet<Carrier>();
            Operatorpositions = new HashSet<OperatorpositionEntity>();
        }

        public int StationId { get; set; }
        public string StatusStation { get; set; }

        public virtual instruction Instruction { get; set; }
        public virtual ICollection<Carrier> Carriers { get; set; }
        public virtual ICollection<OperatorpositionEntity> Operatorpositions { get; set; }
    }
}
