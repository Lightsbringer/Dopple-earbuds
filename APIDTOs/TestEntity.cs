using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.APIDTOs
{
    public partial class TestEntity
    {
        public string TagId { get; set; }
        public int TestId { get; set; }
        public string OrderId { get; set; }

        public virtual OrderEntity Order { get; set; }
        public virtual Carrier Tag { get; set; }
        public virtual Testresult Testresult { get; set; }
    }
}
