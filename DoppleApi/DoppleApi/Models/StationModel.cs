using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoppleApi.Models;

public class StationModel
{
    [Key]
    public int StationId { get; set; }
    public string StatusStation { get; set; }
}

