using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DoppleApi.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


#nullable disable

namespace DoppleApi.Entities
{
    public partial class Instruction
    {
        public string InstructionId { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int StationId { get; set; }
        public virtual Station Station { get; set; }
    }
   
}
