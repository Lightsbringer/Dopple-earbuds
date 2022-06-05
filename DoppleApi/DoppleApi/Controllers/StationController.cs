using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using DoppleApi.Entities;
using DoppleApi.Models;

namespace DoppleApi.Controllers;
    public class StationController
    {
        private readonly bs39hu6mp56dbv0qContext DoppleDB;

        public StationController(bs39hu6mp56dbv0qContext bs39hu6mp56dbv0qContext)
        {
            this.DoppleDB = bs39hu6mp56dbv0qContext;
        }

        [HttpGet("GetStationById")]
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
        [HttpPost("InsertStation")]
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
    }

