using System;
using System.Collections.Generic;

#nullable disable

namespace DoppleMessages
{
    public partial class Test
    {
        public string TagId { get; set; }
        public int TestId { get; set; }
        public string OrderId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Carrier Tag { get; set; }
        public virtual Testresult Testresult { get; set; }
    }
}
