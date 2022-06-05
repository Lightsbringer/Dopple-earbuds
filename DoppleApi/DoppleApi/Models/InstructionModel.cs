using Microsoft.AspNetCore.Mvc;
using DoppleApi.Entities;
namespace DoppleApi.Models;

public class InstructionModel
{
    public string InstructionId { get; set; }
    public int StationId { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }

}
public class InstructionModelWrite
{
    public string InstructionId { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }
}
