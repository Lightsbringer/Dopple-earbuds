using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.APIDTOs
{
    public partial class Carrier
    {
        public Carrier()
        {
            Tests = new HashSet<TestEntity>();
        }

        public string TagId { get; set; }
        public string OrderIdO { get; set; }
        public int StationId { get; set; }
        public string StatusCarrier { get; set; }

        public virtual OrderEntity OrderIdONavigation { get; set; }
        public virtual StationEntity Station { get; set; }
        public virtual ICollection<TestEntity> Tests { get; set; }
    }
}
