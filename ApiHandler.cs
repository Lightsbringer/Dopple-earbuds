using DoppleMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApplication3
{
    public class ApiHandler
    {
        public List<InstructionEntity> GetInstructionsFromApi()
        {

            try
            {
                var resultList = new List<InstructionEntity>();
                var client = new HttpClient();
                var getDataTask = client.GetAsync("https://localhost:44388/GetInstructionById.json?Id=6969")
                    .ContinueWith(response =>
                    {
                        var result = response.Result;
                        if (result.IsSuccessStatusCode)
                        {
                            var readResult = result.Content.ReadAsAsync<List<InstructionEntity>>();
                            readResult.Wait();
                                //result
                                resultList = readResult.Result;
                        }
                    });
                getDataTask.Wait();
                return resultList;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
    public List<StationEntity> GetStationFromAPI()
    {
        try
        {
            var resultList = new List<StationEntity>();
            var client = new HttpClient();
            var getDataTask = client.GetAsync("https://localhost:44388/GetInstructionById.json?Id=6969")
                .ContinueWith(response =>
                {
                    var result = response.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readResult = result.Content.ReadAsAsync<List<InstructionEntity>>();
                        readResult.Wait();
                            //result
                            resultList = readResult.Result;
                    }
                });
            getDataTask.Wait();
            return resultList;
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }
}
}
