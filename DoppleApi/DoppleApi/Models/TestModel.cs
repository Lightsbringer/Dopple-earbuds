using Microsoft.AspNetCore.Mvc;
using DoppleApi.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoppleApi.Models
{
    public class TestModel
    {
        public string TagId { get; set; }
        [Key]
        public int TestId { get; set; }
        public string OrderId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Carrier Tag { get; set; }
        public virtual Testresult Testresult { get; set; }
    }
}
