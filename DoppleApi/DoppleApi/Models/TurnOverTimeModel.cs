using Microsoft.AspNetCore.Mvc;
using DoppleApi.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DoppleApi.Models
{
    public class TurnOverTimeModel
    {
        public string OrderId { get; set; }
        public int StationId { get; set; }
        public DateTime DateStart { get; set; }
        public TimeSpan TimeStart { get; set; }
        public TimeSpan TimeEnd { get; set; }

        //public virtual Order Order { get; set; }
        //public virtual Station Station { get; set; }
    }
}
