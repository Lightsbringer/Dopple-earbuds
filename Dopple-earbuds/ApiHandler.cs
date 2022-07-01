using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebApplication3.APIDTOs;

namespace WebApplication3
{
    public class ApiHandler
    {
        private string URL = "https://localhost:44388/api/";
        public OperatorEntity GetOperatorFromApiByOperatorId(int id)
        {
            try
            {
                var _operator = new OperatorEntity();
                var client = new HttpClient();
                var getDataTask = client.GetAsync(URL + "Operator/GetOperatorById.json?Id=" + id)
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
                getDataTask.Wait();
                return _operator;
            }
            
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool AddStation(int id)
        {
            try
            {
                var client = new HttpClient();
                Post newPost;
                var endpoint = new Uri(URL + "Station/InsertStation.json");
                newPost = new Post()
                {
                    stationId = id,
                    statusStation = "OFFLIN"
                };
                var newPostJson = JsonConvert.SerializeObject(newPost);
                var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                var result = client.PostAsync(endpoint, payload).Result;
                client.Dispose();
                var json = result.Content.ReadAsStringAsync().Result;
                if (result.IsSuccessStatusCode)
                {
                    return true;
                }
                else return false;
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
                var getDataTask = client.GetAsync(URL + "Instruction/GetInstructionById.json?Id=" + id)
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
                getDataTask.Wait();
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
                var getDataTask = client.GetAsync(URL + "Station/GetStationById.json?Id=" + id)
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

        public List<StationEntity> GetAllStationFromApi()
        {
            try
            {
                List<StationEntity> stations = new List<StationEntity>();
                var client = new HttpClient();
                var getDataTask = client.GetAsync(URL + "Station/GetAllCarriers.json")
                    .ContinueWith(response =>
                    {
                        var result = response.Result;
                        if (result.IsSuccessStatusCode)
                        {
                            var readResult = result.Content.ReadAsAsync<List<StationEntity>>();
                            readResult.Wait();
                            stations = readResult.Result;
                        }
                    });
                getDataTask.Wait();
                return stations;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool UpdateStationStatusFromApiById(int id, string status)
        {
            try
            {
                var client = new HttpClient();
                Post newPost;
                var endpoint = new Uri(URL + "Station/UpdateStation.json");
                newPost = new Post()
                {
                    stationId = id,
                    statusStation = status
                };
                var newPostJson = JsonConvert.SerializeObject(newPost);
                var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                var result = client.PutAsync(endpoint, payload).Result;
                client.Dispose();
                var json = result.Content.ReadAsStringAsync().Result;
                if (result.IsSuccessStatusCode)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteStationFromApiById(int id)
        {
            try
            {
                var client = new HttpClient();
                var endpoint = new Uri(URL + "Station/DeleteStation/" + id+".json");
                
                var result = client.DeleteAsync(endpoint).Result;
                client.Dispose();
                var json = result.Content.ReadAsStringAsync().Result;
                if (result.IsSuccessStatusCode)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }


    internal class Post
    {
        public int stationId { get; set; }
        public string statusStation { get; set; }
    }
}

