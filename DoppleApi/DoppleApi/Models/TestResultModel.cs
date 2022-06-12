using Microsoft.AspNetCore.Mvc;
using DoppleApi.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoppleApi.Models
{
    public class TestResultModel
    {
    public int TestId { get; set; }
    public string Result { get; set; }
    public string Reason { get; set; }
    public string OperatorCompanyId { get; set; }

    public virtual Operator OperatorCompany { get; set; }
    public virtual Test Test { get; set; }
}
}
