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

    public class TurnOverTimeController : Controller
    {

        private readonly bs39hu6mp56dbv0qContext DoppleDB;
        public TurnOverTimeController(bs39hu6mp56dbv0qContext bs39hu6mp56dbv0qContext)
        {
            this.DoppleDB = bs39hu6mp56dbv0qContext;
        }

        [HttpGet("GetTurnoOverTimeById.{format}"), FormatFilter]
        public async Task<ActionResult<TurnOverTimeModel>> GetInstructionById(String Id)
        {
            TurnOverTimeModel TurnOverTime = await DoppleDB.Turnovertimes.Select(s => new TurnOverTimeModel
            {

                OrderId = s.OrderId,
                StationId = s.StationId,
                DateStart = s.DateStart,
                TimeStart = s.TimeStart,
                TimeEnd = s.TimeEnd,
            }).FirstOrDefaultAsync(s => s.OrderId == Id);
            if (TurnOverTime == null)
            {
                return null;
            }
            else
            {
                return TurnOverTime;

            }
        }
        [HttpPost("InsertTurnoOverTime.{format}"), FormatFilter]
        public async Task<HttpStatusCode> InsertUser(TurnOverTimeModel TurnOverTime)
        {


            // get existing subject with Id=202
            Station stat = DoppleDB.Stations.FirstOrDefault(s => s.StationId == TurnOverTime.StationId);
           Order order = DoppleDB.Orders.FirstOrDefault(s => s.OrderId == TurnOverTime.OrderId);
            var entity = new Turnovertime()
            {
                OrderId = order.OrderId,
                StationId = stat.StationId,
                DateStart = TurnOverTime.DateStart,
                TimeStart = TurnOverTime.TimeStart,
                TimeEnd = TurnOverTime.TimeEnd,
            };

            DoppleDB.Turnovertimes.Add(entity);

            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.Created;
        }

        [HttpDelete("DeleteTurnoOverTime/{Id}.{format}"), FormatFilter]
        public async Task<HttpStatusCode> DeleteUser(int StationId, String Id)
        {
            var entity = new Turnovertime()
            {
                OrderId = Id,
                StationId = StationId,
            };
            DoppleDB.Turnovertimes.Attach(entity);
            DoppleDB.Turnovertimes.Remove(entity);
            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.OK;
        }
        [HttpGet("UpdateTurnoOverTime.{format}"), FormatFilter]
        public async Task<HttpStatusCode> UpdateUser(TurnOverTimeModel TurnOverTime)
        {
            var entity = await DoppleDB.Turnovertimes.FirstOrDefaultAsync(s => s.OrderId == TurnOverTime.OrderId);
            entity.OrderId = TurnOverTime.OrderId;
               entity.StationId = TurnOverTime.StationId;
                entity.DateStart = TurnOverTime.DateStart;
                entity.TimeStart = TurnOverTime.TimeStart;
                entity.TimeEnd = TurnOverTime.TimeEnd;
            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.OK;
        }

    }
}


