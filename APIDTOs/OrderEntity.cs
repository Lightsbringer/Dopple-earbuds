using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.APIDTOs
{
    public partial class OrderEntity
    {
        public OrderEntity()
        {
            Carriers = new HashSet<Carrier>();
            Tests = new HashSet<TestEntity>();
        }

        public string OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string FaceplateText { get; set; }
        public float EarshellSize { get; set; }
        public string EarshellColor { get; set; }
        public string CradleColor { get; set; }
        public string StatusOrder { get; set; }

        public virtual ICollection<Carrier> Carriers { get; set; }
        public virtual ICollection<TestEntity> Tests { get; set; }
    }
}
