using Microsoft.AspNetCore.Mvc;
using DoppleApi.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DoppleApi.Models
{
    public class OperatorPositionModel
    {
        [Key]
        public string OperatorId { get; set; }
        public int StationId { get; set; }

       // public virtual Operator Operator { get; set; }
       // public virtual Station Station { get; set; }
    }
}
