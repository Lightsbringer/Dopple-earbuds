using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.APIDTOs
{
    public partial class OperatorEntity
        
    {
        public string OperatorId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Authorization { get; set; }

        public virtual OperatorpositionEntity Operatorposition { get; set; }
        public virtual Testresult Testresult { get; set; }
    }
}
