using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication3.APIDTOs;

namespace WebApplication3
{
    public class ApiHandler
    {

        public OperatorEntity GetOperatorFromApiByOperatorId(int id)
        {
            try
            {
                var _operator = new OperatorEntity();
                var client = new HttpClient();
                var getDataTask = client.GetAsync("https://localhost:44388/api/Operator/GetOperatorById.json?Id=" + id)
                .ContinueWith(response =>
                {
                    var result = response.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readResult = result.Content.ReadAsAsync<OperatorEntity>();
                        readResult.Wait();
                        _operator = readResult.Result;
                    }

                });
                return _operator;
            }
            
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public InstructionEntity GetInstructionsFromApiByStationId(int id)
        {

            try
            {
                InstructionEntity instruction = new InstructionEntity();
                var client = new HttpClient();
                var getDataTask = client.GetAsync("https://localhost:44388/api/Instruction/GetInstructionById.json?Id=" + id)
                    .ContinueWith(response =>
                    {
                        var result = response.Result;
                        if (result.IsSuccessStatusCode)
                        {
                            var readResult = result.Content.ReadAsAsync<InstructionEntity>();
                            readResult.Wait();
                            //result
                            instruction = readResult.Result;
                        }
                    });
                return instruction;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public StationEntity GetStationFromApiByStationId(int id)
        {
            try
            {
                StationEntity station = new StationEntity();
                var client = new HttpClient();
                var getDataTask = client.GetAsync("https://localhost:44388/api/Station/GetStationById.json?Id=" + id)
                    .ContinueWith(response =>
                    {
                        var result = response.Result;
                        if (result.IsSuccessStatusCode)
                        {
                            var readResult = result.Content.ReadAsAsync<StationEntity>();
                            readResult.Wait();
                            station = readResult.Result;
                        }
                    });
                getDataTask.Wait();
                return station;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}

