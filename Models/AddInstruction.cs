using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignUp.Models
{
    public class AddInstruction
    {
        public String Name { get; set; }
        public int Step { get; set; }
        public String Description { get; set; }
        public String SelectStation { get; set; }
        public DateTime Time { get; set; }
        
    }
}
