﻿using DoppleApi.Entities;
using DoppleApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
namespace DoppleApi.Controllers
{
   
    public class TestResultController : Controller
    {

        private readonly bs39hu6mp56dbv0qContext DoppleDB;
        PathController pathController = new();
        public String schemaName = "TestResult";
        public TestResultController(bs39hu6mp56dbv0qContext bs39hu6mp56dbv0qContext)
        {
            this.DoppleDB = bs39hu6mp56dbv0qContext;
        }
        // get test result by id in either XML or  JSON format
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
                var path = pathController.GetUri();
                pathController.validateXMLorJSON(path, schemaName);
                return TestResult;

            }
        }
        // insert test result by id in either XML or  JSON format
        [HttpPost("InsertTestResult.{format}"), FormatFilter]
        public async Task<HttpStatusCode> InsertUser(TestResultModel TestResult)
        {


            
            Test test = DoppleDB.Tests.FirstOrDefault(s => s.TestId == TestResult.TestId);
            Operator opr = DoppleDB.Operators.FirstOrDefault(s => s.OperatorId == TestResult.OperatorCompanyId);
            var entity = new Testresult()
            {
                TestId = test.TestId,
                Result = TestResult.Result,
                Reason = TestResult.Reason,
                OperatorCompanyId = opr.OperatorId,
            };
            var path = pathController.GetUri();
            pathController.validateXMLorJSON(path, schemaName);
            DoppleDB.Testresults.Add(entity);

            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.Created;
        }

        // delete test result by id and operatorID in either XML or  JSON format
        [HttpDelete("DeleteTestResult/{Id}.{format}"), FormatFilter]
        public async Task<HttpStatusCode> DeleteUser(int Id, String operatorId) 
        {
            var entity = new Testresult()
            {
                TestId = Id,
              
                OperatorCompanyId = operatorId,
            };
            var path = pathController.GetUri();
            pathController.validateXMLorJSON(path, schemaName);
            DoppleDB.Testresults.Attach(entity);
            DoppleDB.Testresults.Remove(entity);
            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.OK;
        }
        // update etst result by id in either XML or  JSON format
        [HttpPut("UpdateTestResultById.{format}"), FormatFilter]
        public async Task<HttpStatusCode> UpdateUser(TestResultModel TestResult)
        {
            var entity = await DoppleDB.Testresults.FirstOrDefaultAsync(s => s.TestId == TestResult.TestId && s.OperatorCompanyId == TestResult.OperatorCompanyId);
            entity.Result = TestResult.Result;
            entity.Reason = TestResult.Reason;
            entity.OperatorCompanyId = TestResult.OperatorCompanyId;
            var path = pathController.GetUri();
            pathController.validateXMLorJSON(path, schemaName);
            await DoppleDB.SaveChangesAsync();
            return HttpStatusCode.OK;
        }

    }
}


