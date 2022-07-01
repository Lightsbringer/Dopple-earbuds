using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.APIDTOs
{
    public partial class Turnovertime
    {
        public string OrderId { get; set; }
        public int StationId { get; set; }
        public DateTime DateStart { get; set; }
        public TimeSpan TimeStart { get; set; }
        public TimeSpan TimeEnd { get; set; }

        public virtual OrderEntity Order { get; set; }
        public virtual StationEntity Station { get; set; }
    }
}
