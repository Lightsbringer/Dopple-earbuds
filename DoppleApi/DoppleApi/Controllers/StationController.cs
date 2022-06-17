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
       // private IHttpContextAccessor Accessor;
        // ValidatorXSD validatorXSD = new ValidatorXSD();
        //this is used for validation not yet fully working
        //JsonDraft007 jsonDraft007 = new JsonDraft007();
        //PathController pathController = new PathController();
        //String fileName = "C:\\Users\\hunte\\source\\repos\\DoppleApi\\DoppleApi\\StationXmlSchema.xml";


        public StationController(bs39hu6mp56dbv0qContext bs39hu6mp56dbv0qContext, IHttpContextAccessor _accessor)
        {
            this.DoppleDB = bs39hu6mp56dbv0qContext;
            //this.Accessor = _accessor;
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
                //WriteXML(Station);
                // validatorXSD.ValidateXML(fileName);
               // jsonDraft007.random();
               // pathController.GetUri();
                return Station;
                

            }
        }
        //used for writting XML file from an object, didnt work quite well
        //public void WriteXML(Station stationModel)
        //{
        //    stationModel.StatusStation = stationModel.StatusStation;
        //    stationModel.StationId = stationModel.StationId;
        //    System.Xml.Serialization.XmlSerializer writer =
        //        new System.Xml.Serialization.XmlSerializer(typeof(Station));
            

        //    var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//StationXmlSchema.xml";
        //    System.IO.FileStream file = System.IO.File.Create(path);

        //    writer.Serialize(file, stationModel);
        //    file.Close();
        //}

        // insert station by id in either XML or  JSON format
        [HttpPost("InsertStation.{format}"), FormatFilter]
        public async Task<HttpStatusCode> InsertUser(StationModel Station)
        {
            var entity = new Station()
            {
                StationId = Station.StationId,
                StatusStation = Station.StatusStation,
             
        };
            DoppleDB.Stations.Add(entity);
           // WriteXML(entity);
           // validatorXSD.ValidateXML(fileName);
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
            DoppleDB.Stations.Attach(entity);
            DoppleDB.Stations.Remove(entity);
            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.OK;
        }

        // update station by id in in either XML or  JSON format
        [HttpPut("UpdateStation.{format}"), FormatFilter]
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