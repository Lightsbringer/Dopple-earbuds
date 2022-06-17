using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3;

namespace WebApplication3.Models
{
    public class AddInstruction
    {

        public String InstructionId { get; set; }
        public int ImagePath { get; set; }
        public String Description { get; set; }
        public String StationId { get; set; }
        public DateTime Time { get; set; }
        
    }
}
