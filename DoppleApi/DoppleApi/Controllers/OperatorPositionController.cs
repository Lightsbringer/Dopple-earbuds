using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using DoppleApi.Entities;
using DoppleApi.Models;


namespace Dopple_API.Controllers
{

    public class OperatorPositionController : Controller
    {
        
        private readonly bs39hu6mp56dbv0qContext DoppleDB;
        public OperatorPositionController(bs39hu6mp56dbv0qContext bs39hu6mp56dbv0qContext)
        {
            this.DoppleDB = bs39hu6mp56dbv0qContext;
        }

        [HttpGet("GetOperatorPositionById.{format}"), FormatFilter]
        public async Task<ActionResult<OperatorPositionModel>> GetInstructionById(String Id)
        {
            OperatorPositionModel OperatorPosition = await DoppleDB.Operatorpositions.Select(s => new OperatorPositionModel
            {
                OperatorId = s.OperatorId,
                StationId = s.StationId,
            }).FirstOrDefaultAsync(s => s.OperatorId == Id);
            if (OperatorPosition == null)
            {
                return null;
            }
            else
            {
                return OperatorPosition;

            }
        }
        [HttpPost("InsertOperatorPosition.{format}"), FormatFilter]
        public async Task<HttpStatusCode> InsertUser(OperatorPositionModel OperatorPosition)
        {


            // get existing subject with Id=202
            Station stat = DoppleDB.Stations.FirstOrDefault(s => s.StationId == OperatorPosition.StationId);
            Operator opr = DoppleDB.Operators.FirstOrDefault(s => s.OperatorId == OperatorPosition.OperatorId);
            var entity = new Operatorposition()
            {
                OperatorId = opr.OperatorId,
                StationId = stat.StationId,
            };

            DoppleDB.Operatorpositions.Add(entity);

            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.Created;
        }

        [HttpDelete("DeleteOperatorPosition/{Id}.{format}"), FormatFilter]
        public async Task<HttpStatusCode> DeleteUser(String Id)
        {
            var entity = new Operatorposition()
            {
                OperatorId = Id,
            };
            DoppleDB.Operatorpositions.Attach(entity);
            DoppleDB.Operatorpositions.Remove(entity);
            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.OK;
        }
        [HttpPut("UpdateOperatorPosition.{format}"), FormatFilter]
        public async Task<HttpStatusCode> UpdateUser(OperatorPositionModel OperatorPosition)
        {
            var entity = await DoppleDB.Operatorpositions.FirstOrDefaultAsync(s => s.OperatorId == OperatorPosition.OperatorId);
            entity.OperatorId = OperatorPosition.OperatorId;
            entity.StationId = OperatorPosition.StationId;
            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.OK;
        }

        
    }
}



