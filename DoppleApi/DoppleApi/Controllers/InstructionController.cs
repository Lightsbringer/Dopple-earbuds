using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using DoppleApi.Entities;
using DoppleApi.Models;
using DoppleApi;
using Microsoft.AspNetCore.Mvc.Rendering;
using MySql.Data.MySqlClient;

namespace Dopple_API.Controllers
{

    public class InstructionController : Controller
    {
        private readonly bs39hu6mp56dbv0qContext DoppleDB;
        public InstructionController(bs39hu6mp56dbv0qContext bs39hu6mp56dbv0qContext)
        {
            this.DoppleDB = bs39hu6mp56dbv0qContext;
        }

        [HttpGet("GetInstructionById.{format}"), FormatFilter]
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
        [HttpPost("InsertInstruction.{format}"), FormatFilter]
        public async Task<HttpStatusCode> InsertUser(InstructionModel Instructions)
        {
           

                // get existing subject with Id=202
                Station stat = DoppleDB.Stations.FirstOrDefault(s => s.StationId == Instructions.StationId);
            var entity = new Instruction()
            {
                InstructionId = Instructions.InstructionId,
                Description = Instructions.Description,
                ImagePath = Instructions.ImagePath,
                StationId = stat.StationId,
            };

        DoppleDB.Instructions.Add(entity);
            
            await DoppleDB.SaveChangesAsync();
           return HttpStatusCode.Created;
            }

        [HttpDelete("DeleteInstruction/{Id}.{format}"), FormatFilter]
        public async Task<HttpStatusCode> DeleteUser(String Id)
        {
            var entity = new Instruction()
            {
                InstructionId = Id,
            };
            DoppleDB.Instructions.Attach(entity);
            DoppleDB.Instructions.Remove(entity);
            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.OK;
        }
        [HttpPut("UpdateInstruction.{format}"), FormatFilter]
        public async Task<HttpStatusCode> UpdateUser(InstructionModel Instructions)
        {
            var entity = await DoppleDB.Instructions.FirstOrDefaultAsync(s => s.InstructionId == Instructions.InstructionId);
            entity.InstructionId = Instructions.InstructionId; 
                entity.Description = Instructions.Description;
            entity.ImagePath = Instructions.ImagePath;
            entity.StationId = Instructions.StationId;
            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.OK;
        }

        //private int clean_table(string table)
        //{
        //    try
        //    {
        //        using (DoppleDB)
        //        {


        //            String sql = "SET FOREIGN_KEY_CHECKS=0";

        //            using (MySqlCommand comm = new MySqlCommand(sql, DoppleDB))
        //            {
        //                comm.ExecuteNonQuery();
        //            }
        //            conn.Close();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        log.Error("clean_table " + e.Message);
        //        return 0;
        //    }

        //    return 1;
        //}        
    }
}
        //public async Task<HttpStatusCode> InsertUser(InstructionModel Instructions)
        //{
            
        //    var entity = new Instruction()
        //    {
        //        InstructionId = Instructions.InstructionId,
        //        Description = Instructions.Description,
        //        ImagePath = Instructions.ImagePath,

        //    };

        //    DoppleDB.Instructions.Add(entity);
        //    await DoppleDB.SaveChangesAsync();
        //    return HttpStatusCode.Created;
        //}
        //private List<SelectListItem> GetInstructions()
        //{
        //    var lstInstructions = new List<SelectListItem>();
        //    //PaginatedList<InstructionModel> instructions = _instructionModels.Station("StationId");

        //}
        //.{format}"), FormatFilter

    
