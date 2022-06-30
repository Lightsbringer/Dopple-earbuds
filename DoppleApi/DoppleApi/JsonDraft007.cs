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
     
        //default schema
        JSchema schema = JSchema.Parse(File.ReadAllText(@"..\DoppleApi\JsonSchemas\TurnOverTimeJSONSchema.json"));
        public async void validateJson(String methodPath)
        {
          
            using (var client = new HttpClient())
            {
                IHttpContextAccessor accessor = new HttpContextAccessor();
                var host = accessor.HttpContext.Request.Host;
                String baseUrl = "https://" + host;
               
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
                        //display "schema validated succesfully in the future.
                        Console.WriteLine("sucess");
                    }
                    else if (valid == false)
                    {
                        
                        throw new JSchemaValidationException("The schema is not the same as the one provided from the API" + messages[0]);
                        

                    }


                }

            }

        }
        public JSchema jSchemaPath(String path)
        {
            
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
