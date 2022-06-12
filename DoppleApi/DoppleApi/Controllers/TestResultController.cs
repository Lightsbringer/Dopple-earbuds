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

    public class TestResultController : Controller
    {

        private readonly bs39hu6mp56dbv0qContext DoppleDB;
        public TestResultController(bs39hu6mp56dbv0qContext bs39hu6mp56dbv0qContext)
        {
            this.DoppleDB = bs39hu6mp56dbv0qContext;
        }

        [HttpGet("GetTestResultById.{format}"), FormatFilter]
        public async Task<ActionResult<TestResultModel>> GetInstructionById(int Id)
        {
            TestResultModel TestResult = await DoppleDB.Testresults.Select(s => new TestResultModel
            {

                TestId = s.TestId,
                Result = s.Result,
                Reason = s.Reason,
                OperatorCompanyId = s.OperatorCompanyId,

            }).FirstOrDefaultAsync(s => s.TestId == Id);
            if (TestResult == null)
            {
                return null;
            }
            else
            {
                return TestResult;

            }
        }
        [HttpPost("InsertTestResult.{format}"), FormatFilter]
        public async Task<HttpStatusCode> InsertUser(TestResultModel TestResult)
        {


            // get existing subject with Id=202
           Test test = DoppleDB.Tests.FirstOrDefault(s => s.TestId == TestResult.TestId);
            Operator opr = DoppleDB.Operators.FirstOrDefault(s => s.OperatorId == TestResult.OperatorCompanyId);
            var entity = new Testresult()
            {
                TestId = test.TestId,
                Result = TestResult.Result,
                Reason = TestResult.Reason,
                OperatorCompanyId = opr.OperatorId,
            };

            DoppleDB.Testresults.Add(entity);

            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.Created;
        }
        
        [HttpDelete("DeleteTestResult/{Id}.{format}"), FormatFilter]
        public async Task<HttpStatusCode> DeleteUser(int Id,String operatorId)
        {
            var entity = new Testresult()
            {
                TestId = Id,
                OperatorCompanyId = operatorId,
            };
            DoppleDB.Testresults.Attach(entity);
            DoppleDB.Testresults.Remove(entity);
            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.OK;
        }
        [HttpGet("UpdateTestResultById.{format}"), FormatFilter]
        public async Task<HttpStatusCode> UpdateUser(TestResultModel TestResult)
        {
            var entity = await DoppleDB.Testresults.FirstOrDefaultAsync(s => s.TestId == TestResult.TestId);
            entity.TestId = TestResult.TestId;
            entity.Result = TestResult.Result;
            entity.Reason = TestResult.Reason;
            entity.OperatorCompanyId = TestResult.OperatorCompanyId;
            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.OK;
        }

    }
}


