using Microsoft.AspNetCore.Mvc;
using DoppleApi.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoppleApi.Models
{

    public class InstructionModel
    {
        [Key]
        public string InstructionId { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ImagePath { get; set; }
        public int StationId { get; set; }
        [Required]
        [ForeignKey("StationId")]
        public virtual StationModel Station { get; set; }

    }
}
