using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using DoppleApi.Entities;
using DoppleApi.Models;
namespace Dopple_API.Controllers
{

    public class CarrierController : Controller
    {
        

        private readonly bs39hu6mp56dbv0qContext DoppleDB;

        public CarrierController(bs39hu6mp56dbv0qContext bs39hu6mp56dbv0qContext)
        {
            this.DoppleDB = bs39hu6mp56dbv0qContext;
        }

        [HttpGet("GetCarrierById.{format}"), FormatFilter]
        public async Task<ActionResult<CarrierModel>> GetOrderById(String Id)
        {
            CarrierModel Carrier = await DoppleDB.Carriers.Select(s => new CarrierModel
            {
                TagId = s.TagId,
                OrderIdO = s.OrderIdO,
                StationId = s.StationId,
                StatusCarrier = s.StatusCarrier,

            }).FirstOrDefaultAsync(s => s.TagId == Id);
            if (Carrier == null)
            {
                return null;
            }
            else
            {
                return Carrier;
            }
        }
        [HttpPost("InsertCarrier.{format}"), FormatFilter]
        public async Task<HttpStatusCode> InsertUser(CarrierModel Carrier)
        {


            
            Station stat = DoppleDB.Stations.FirstOrDefault(s => s.StationId == Carrier.StationId);
            Order order = DoppleDB.Orders.FirstOrDefault(s => s.OrderId == Carrier.OrderIdO);
            var entity = new Carrier()
            {
                TagId = Carrier.TagId,
                OrderIdO = order.OrderId,
                StationId = stat.StationId,
                StatusCarrier = Carrier.StatusCarrier,
                
            };

            DoppleDB.Carriers.Add(entity);

            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.Created;
        }
        [HttpDelete("DeleteCarrier/{Id}.{format}"), FormatFilter]
        public async Task<HttpStatusCode> DeleteUser(String Id)
        {
            var entity = new Carrier()
            {
                TagId = Id,
            };
            DoppleDB.Carriers.Attach(entity);
            DoppleDB.Carriers.Remove(entity);
            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.OK;
        }


        [HttpPost("UpdateCarrier.{format}"), FormatFilter]
        public async Task<HttpStatusCode> UpdateOrder(CarrierModel Carrier)
        {
            var entity = await DoppleDB.Carriers.FirstOrDefaultAsync(s => s.TagId == Carrier.TagId);

            entity.TagId = Carrier.TagId;
            entity.OrderIdO = Carrier.OrderIdO;
            entity.StationId = Carrier.StationId;
            entity.StatusCarrier = Carrier.StatusCarrier;

            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.OK;
        }
        
    }

}