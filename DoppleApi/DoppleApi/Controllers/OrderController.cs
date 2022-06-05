using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using DoppleApi.Entities;
using DoppleApi.Models;
namespace Dopple_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {

        private readonly bs39hu6mp56dbv0qContext DoppleDB;

        public OrderController(bs39hu6mp56dbv0qContext bs39hu6mp56dbv0qContext)
        {
            this.DoppleDB = bs39hu6mp56dbv0qContext;
        }

        [HttpGet("GetOrderById")]
        public async Task<ActionResult<OrderModel>> GetOrderById(String Id)
        {
            OrderModel Orders = await DoppleDB.Orders.Select(s => new OrderModel
            {
                OrderId = s.OrderId,
                OrderDate = s.OrderDate,
                FaceplateText = s.FaceplateText,
                EarshellSize = s.EarshellSize,
                EarshellColor = s.EarshellColor,
                CradleColor = s.CradleColor,
                StatusOrder = s.StatusOrder,
            }).FirstOrDefaultAsync(s => s.OrderId == Id);
            if (Orders == null)
            {
                return null;
            }
            else
            {
                return Orders;
            }
        }
        [HttpPost("InsertUser")]
        public async Task<HttpStatusCode> InsertUser(OrderModel Order)
        {
            var entity = new Order()
            {
                OrderId = Order.OrderId,
                OrderDate = Order.OrderDate,
                FaceplateText = Order.FaceplateText,
                EarshellSize = Order.EarshellSize,
                EarshellColor = Order.EarshellColor,
                CradleColor = Order.CradleColor,
                StatusOrder = Order.StatusOrder,

            };
            DoppleDB.Orders.Add(entity);
            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.Created;
        }
    }
    
}