using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.APIDTOs;

namespace WebApplication3.Models
{
    public class UserPage
    {
        public int StationId { get; set; }
        public string ImagePath { get; set; }
        public string OperatorId { get; set; }
        public string Description { get; set; }
        public int InstructionId { get; set; }


    }
}
