using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


#nullable disable

namespace WebApplication3.APIDTOs

{
    public partial class InstructionEntity
    {
        public string InstructionId { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int StationId { get; set; }
        public virtual StationEntity Station { get; set; }
    }

}
