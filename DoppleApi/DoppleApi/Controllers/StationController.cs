using DoppleApi.Entities;
using DoppleApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using DoppleApi;
using Newtonsoft.Json.Schema;
using Microsoft.AspNetCore.Http;

namespace DoppleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StationController : Controller
    {
        private readonly bs39hu6mp56dbv0qContext DoppleDB;
        PathController pathController = new();
        public String schemaName = "Station";


        public StationController(bs39hu6mp56dbv0qContext bs39hu6mp56dbv0qContext, IHttpContextAccessor _accessor)
        {
            this.DoppleDB = bs39hu6mp56dbv0qContext;
            //this.Accessor = _accessor;
        }
        [HttpGet("GetAllCarriers.{format}"), FormatFilter]
        public async Task<List<Station>> GetAllCarriers()
        {
            var stations = new List<Station>();
            var allStations = await DoppleDB.Stations.ToListAsync();
            if (stations?.Any() == true)
            {
                foreach (var station in allStations)
                {
                    stations.Add(new Station()
                    {
                        StationId = station.StationId,
                        StatusStation = station.StatusStation,
                    });

                }
            }
            return allStations;


        }

        // get station by id in either XML or  JSON format
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
                var path = pathController.GetUri();
                pathController.validateXMLorJSON(path, schemaName);
                return Station;
                

            }
        }
 
        // insert station by id in either XML or  JSON format
        [HttpPost("InsertStation.{format}"), FormatFilter]
        public async Task<HttpStatusCode> InsertUser(StationModel Station)
        {
            var entity = new Station()
            {
                StationId = Station.StationId,
                StatusStation = Station.StatusStation,

            };
            var path = pathController.GetUri();
            pathController.validateXMLorJSON(path, schemaName);
            DoppleDB.Stations.Add(entity);

            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.Created;
        }
        // delete station by id in either XML or  JSON format
        [HttpDelete("DeleteStation/{Id}.{format}"), FormatFilter]
        public async Task<HttpStatusCode> DeleteUser(int Id)
        {
            var entity = new Station()
            {
                StationId = Id,
            };
            var path = pathController.GetUri();
            pathController.validateXMLorJSON(path, schemaName);
            DoppleDB.Stations.Attach(entity);
            DoppleDB.Stations.Remove(entity);
            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.OK;
        }

        // update station by id in in either XML or  JSON format
        [HttpPut("UpdateStation.{format}"), FormatFilter]
        public async Task<HttpStatusCode> UpdateOrder(StationModel Station)
        {
            var entity = await DoppleDB.Stations.FirstOrDefaultAsync(s => s.StationId == Station.StationId);

            entity.StatusStation = Station.StatusStation;
            var path = pathController.GetUri();
            pathController.validateXMLorJSON(path, schemaName);
            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.OK;
        }

    
    }
}