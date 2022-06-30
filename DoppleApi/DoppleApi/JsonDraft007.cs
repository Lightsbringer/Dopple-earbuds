using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System.Net.Http.Headers;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace DoppleApi
{
    public class JsonDraft007
    {
        //private JSchema schema2 = new JSchema();
        //private JSchema schema = new JSchema();
        //public String results = "";        

        JSchema schema = JSchema.Parse(File.ReadAllText(@"..\DoppleApi\JsonSchemas\TurnOverTimeJSONSchema.json"));
        public async void random(String methodPath)
        {
            
            //using (StreamReader file = File.OpenText(@"C:\\Users\\hunte\\source\\repos\\DoppleApi\\DoppleApi\\StationJSONSchema.json"))
            //using (JsonTextReader reader = new(file))
            //{
            //    JSchema schema2 = JSchema.Load(reader);
            //}
            //JSchema schema = JSchema.Parse(schema1);

            /*JObject person = JObject.Parse(@"{
  'stationId': '11',
  'hobbies': ['.NET', 'Blogging', 'Reading', 'Xbox', 'LOLCATS']
}"
            );*/
            using (var client = new HttpClient())
            {
                // HttpContext Context = HttpContext.Current;
                // String baseUrl = HttpContext.Request.Url.AbsoluteUri;
                //  string surl = string.Format("{0}://{1}",
                //   HttpContext.Current.Request.Url.Scheme);
                //string sPath = new Uri(HttpContext.AbsoluteUri).OriginalString; System.Web.HttpContext.Current.Request.Url.AbsolutePath;
                //sPath = sPath.Replace("http://", "");
                //System.IO.FileInfo oInfo = new System.IO.FileInfo(sPath);
                //string sRet = oInfo.Name;
                //Response.Write(sPath.Replace(sRet, ""));

                String baseUrl = "https://localhost:7267";
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage getData = await client.GetAsync(methodPath);
                IList<string> messages = new List<string>();
                SchemaValidationEventHandler validationEventHandler = (sender, args) => messages.Add(args.Message);
                if (getData.IsSuccessStatusCode)
                {
                    String results = getData.Content.ReadAsStringAsync().Result;
                    JToken result = JToken.Parse(results);
                    result.Validate(schema, validationEventHandler);
                    bool valid = result.IsValid(schema, out messages);

                    if (valid == true)
                    {
                        Console.WriteLine("dick");
                    }
                    else if (valid == false)
                    {
                        throw new JSchemaValidationException("The schema is not the same as the one provided from the API" + messages[0]);
                        

                    }

                    // Console.WriteLine(result.Validate(schema1, validationEventHandler));

                    //foreach (string message in messages)
                    //    {
                    //        Console.WriteLine(message);
                    //    }

                }


                //JArray resultArr = JArray.Parse(results);

            }

            /*
            https://localhost:44388/api/Carrier/GetAllCarriers.xml
             */

            // true
        }
        public JSchema jSchemaPath(String path)
        {
           // JSchema schema = JSchema.Parse(File.ReadAllText(@"..\DoppleApi\JsonSchemas\StationJSONSchema.json"));
            
            switch (path)
            {
                case "Carrier":
                     schema = JSchema.Parse(File.ReadAllText(@"..\DoppleApi\JsonSchemas\CarrierJSONSchema.json"));
                    break;
                case "Instruction":
                     schema = JSchema.Parse(File.ReadAllText(@"..\DoppleApi\JsonSchemas\InstructionJSONSchema.json"));
                    break;
                case "Operator":
                     schema = JSchema.Parse(File.ReadAllText(@"..\DoppleApi\JsonSchemas\OperatorJSONSchema.json"));
                    break;
                case "OperatorPosition":
                     schema = JSchema.Parse(File.ReadAllText(@"..\DoppleApi\JsonSchemas\OperatorPositionJSONSchema.json"));
                    break;
                case "Order":
                     schema = JSchema.Parse(File.ReadAllText(@"..\DoppleApi\JsonSchemas\OrderJSONSchema.json"));
                    break;
                case "Station":
                     schema = JSchema.Parse(File.ReadAllText(@"..\DoppleApi\JsonSchemas\StationJSONSchema.json"));
                    break;
                case "Test":
                     schema = JSchema.Parse(File.ReadAllText(@"..\DoppleApi\JsonSchemas\TestJSONSchema.json"));
                    break;
                case "TestResult":
                     schema = JSchema.Parse(File.ReadAllText(@"..\DoppleApi\JsonSchemas\TestResultJSONSchema.json"));
                    break;
                case "TurnOverTime":
                     schema= JSchema.Parse(File.ReadAllText(@"..\DoppleApi\JsonSchemas\TurnOverTimeJSONSchema.json"));
                    break;

            }
            return schema;
        }
        
    }
}
