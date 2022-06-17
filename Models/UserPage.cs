using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class UserPage
    {
        public class instruction
        {
            public string instructionId { get; set; }
            public string description { get; set; }
            public string imagePath { get; set; }
            public int stationId { get; set; }
        }
        public class station
        {
            public int stationId { get; set; }
            public string statusStation { get; set; }

        }
       

    }
}
