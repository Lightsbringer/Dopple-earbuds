using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3;

namespace WebApplication3.Models
{
    public class AddInstruction
    {

        public string InstructionId { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public string StationId { get; set; }
        public DateTime Time { get; set; }
        
    }
}
