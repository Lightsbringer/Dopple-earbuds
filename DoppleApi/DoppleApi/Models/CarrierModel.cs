using Microsoft.AspNetCore.Mvc;
using DoppleApi.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoppleApi.Models
{
    public class CarrierModel
    {
        [Key]
        public string TagId { get; set; }
        public string OrderIdO { get; set; }
        public int StationId { get; set; }
        public string StatusCarrier { get; set; }

        public virtual Order OrderIdONavigation { get; set; }
        public virtual Station Station { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
    }
}
