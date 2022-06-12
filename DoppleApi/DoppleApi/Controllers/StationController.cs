using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using DoppleApi.Entities;
using DoppleApi.Models;


namespace DoppleApi.Controllers
{
 
    public class StationController : Controller
    {
        private readonly bs39hu6mp56dbv0qContext DoppleDB;

        public StationController(bs39hu6mp56dbv0qContext bs39hu6mp56dbv0qContext)
        {
            this.DoppleDB = bs39hu6mp56dbv0qContext;
        }

        [HttpGet("GetStationById.{format}"), FormatFilter]
        public async Task<ActionResult<StationModel>> GetStatusById(int Id)
        {
            StationModel Station = await DoppleDB.Stations.Select(s => new StationModel
            {
                StationId = s.StationId,
                StatusStation = s.StatusStation,

            }).FirstOrDefaultAsync(s => s.StationId == Id);
            if (Station == null)
            {
                return null;
            }
            else
            {
                return Station;
            }
        }
        [HttpPost("InsertStation.{format}"), FormatFilter]
        public async Task<HttpStatusCode> InsertUser(StationModel Station)
        {
            var entity = new Station()
            {
                StationId = Station.StationId,
                StatusStation = Station.StatusStation,

            };
            DoppleDB.Stations.Add(entity);
            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.Created;
        }
        [HttpDelete("DeleteStation/{Id}.{format}"), FormatFilter]
        public async Task<HttpStatusCode> DeleteUser(int Id)
        {
            var entity = new Station()
            {
                StationId = Id,
            };
            DoppleDB.Stations.Attach(entity);
            DoppleDB.Stations.Remove(entity);
            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.OK;
        }


        [HttpPost("UpdateStation.{format}"), FormatFilter]
        public async Task<HttpStatusCode> UpdateOrder(StationModel Station)
        {
            var entity = new Station();
            entity.StationId = Station.StationId;
            entity.StatusStation = Station.StatusStation;
            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.OK;
        }
    }

}