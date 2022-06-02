using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using Dopple_API.Entities;
using Dopple_API.Models;
namespace Dopple_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {

        private readonly j5842kjhvn2qpp5vContext j5842kjhvn2qpp5vContext;

        public OrderController(j5842kjhvn2qpp5vContext j5842kjhvn2qpp5vContext)
        {
            this.j5842kjhvn2qpp5vContext = j5842kjhvn2qpp5vContext;
        }


        [HttpGet("GetOrderById")]
        public async Task<ActionResult<OrderModel>> GetOrderById(String Id)
        {
            OrderModel Orders = await j5842kjhvn2qpp5vContext.Orders.Select(s => new OrderModel
            {
                OrderId = s.OrderId,
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
                StatusOrder = Order.StatusOrder,

            };
            j5842kjhvn2qpp5vContext.Orders.Add(entity);
            await j5842kjhvn2qpp5vContext.SaveChangesAsync();
            return HttpStatusCode.Created;
        }
    }
}