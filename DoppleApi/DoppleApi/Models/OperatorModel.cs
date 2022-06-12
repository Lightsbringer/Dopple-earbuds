using Microsoft.AspNetCore.Mvc;
using DoppleApi.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoppleApi.Models
{
    public class OperatorModel
    {
        [Key]
        public string OperatorId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Authorization { get; set; }

        //public virtual Operatorposition Operatorposition { get; set; }
      //  public virtual Testresult Testresult { get; set; }
    }
}
