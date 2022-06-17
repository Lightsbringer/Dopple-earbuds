using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.APIDTOs;

namespace WebApplication3.Models
{
    public class UserPage
    {
        public StationEntity station;
        public InstructionEntity instruction;
        public OperatorEntity @operator;

        public UserPage(StationEntity station, InstructionEntity instruction, OperatorEntity @operator)
        {
            this.station = station;
            this.instruction = instruction;
            this.@operator = @operator;
        }
    }
    
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
    public class Operator
    {
        public int operatorId { get; set; }
    }

}
