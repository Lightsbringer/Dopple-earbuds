using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using DoppleApi.Entities;
using DoppleApi.Models;
namespace Dopple_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InstructionController : Controller
    {
        private readonly bs39hu6mp56dbv0qContext DoppleDB;

        public InstructionController(bs39hu6mp56dbv0qContext bs39hu6mp56dbv0qContext)
        {
            this.DoppleDB = bs39hu6mp56dbv0qContext;
        }
        // UNDER CONSTRUCTION , USE AT YOUR OWN RISK
        [HttpGet("GetInstructionById")]
        public async Task<ActionResult<InstructionModel>> GetInstructionById(String Id)
        {
            InstructionModel Instructions = await DoppleDB.Instructions.Select(s => new InstructionModel
            {
                InstructionId = s.InstructionId,
                StationId = s.StationId,
                Description = s.Description,
                ImagePath = s.ImagePath,
            }).FirstOrDefaultAsync(s => s.InstructionId == Id);
            if (Instructions == null)
            {
                return null;
            }
            else
            {
                return Instructions;

            }
        }
        [HttpPost("InsertInstruction")]
        public async Task<HttpStatusCode> InsertUser(InstructionModel Instructions)
        {
            var entity = new Instruction()
            {
                InstructionId = Instructions.InstructionId,
                Description = Instructions.Description,
                ImagePath = Instructions.ImagePath,

            };
            DoppleDB.Instructions.Add(entity);
            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.Created;
        }
    }
}

