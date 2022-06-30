using DoppleApi.Entities;
using DoppleApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace DoppleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : Controller
    {

        private readonly bs39hu6mp56dbv0qContext DoppleDB;
        PathController pathController = new();
        public String schemaName = "Test";
        public TestController(bs39hu6mp56dbv0qContext bs39hu6mp56dbv0qContext)
        {
            this.DoppleDB = bs39hu6mp56dbv0qContext;
        }

        [HttpGet("GetTestById.{format}"), FormatFilter]
        public async Task<ActionResult<TestModel>> GetInstructionById(int Id)
        {
            TestModel Test = await DoppleDB.Tests.Select(s => new TestModel
            {
                TagId = s.TagId,
                TestId = s.TestId,
                OrderId = s.OrderId,

            }).FirstOrDefaultAsync(s => s.TestId == Id);
            if (Test == null)
            {
                return null;
            }
            else
            {
                var path = pathController.GetUri();
                pathController.validateXMLorJSON(path, schemaName);
                return Test;

            }
        }
        [HttpPost("InsertTest.{format}"), FormatFilter]
        public async Task<HttpStatusCode> InsertUser(TestModel Test)
        {


            // get existing subject with Id=202
            Carrier carrier = DoppleDB.Carriers.FirstOrDefault(s => s.TagId == Test.TagId);
            Order order = DoppleDB.Orders.FirstOrDefault(s => s.OrderId == Test.OrderId);
            var entity = new Test()
            {
                TagId = carrier.TagId,
                TestId = Test.TestId,
                OrderId = order.OrderId,
            };
            var path = pathController.GetUri();
            pathController.validateXMLorJSON(path, schemaName);
            DoppleDB.Tests.Add(entity);

            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.Created;
        }

        [HttpDelete("DeleteTest/{Id}.{format}"), FormatFilter]
        public async Task<HttpStatusCode> DeleteUser(int Id)
        {
            var entity = new Test()
            {
                TestId = Id,
            };
            var path = pathController.GetUri();
            pathController.validateXMLorJSON(path, schemaName);
            DoppleDB.Tests.Attach(entity);
            DoppleDB.Tests.Remove(entity);
            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.OK;
        }
        [HttpPut("UpdateTestById.{format}"), FormatFilter]
        public async Task<HttpStatusCode> UpdateUser(TestModel Test)
        {
            var entity = await DoppleDB.Tests.FirstOrDefaultAsync(s => s.TestId == Test.TestId);
            entity.TagId = Test.TagId;
            entity.OrderId = Test.OrderId;
            var path = pathController.GetUri();
            pathController.validateXMLorJSON(path, schemaName);
            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.OK;
        }

    }
}


