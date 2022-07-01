using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.APIDTOs
{
    public partial class Testresult
    {
        public int TestId { get; set; }
        public string Result { get; set; }
        public string Reason { get; set; }
        public string OperatorCompanyId { get; set; }

        public virtual OperatorEntity OperatorCompany { get; set; }
        public virtual TestEntity Test { get; set; }
    }
}
