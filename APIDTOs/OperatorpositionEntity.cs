using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.APIDTOs
{
    public partial class OperatorpositionEntity
    {
        public string OperatorId { get; set; }
        public int StationId { get; set; }

        public virtual OperatorEntity Operator { get; set; }
        public virtual StationEntity Station { get; set; }
    }
}
