using Microsoft.AspNetCore.Mvc;

namespace DoppleApi.Controllers
{
    //this clas is used for validation purposes
   
    // it gets the path from the other controllers and sends it to jsonDraft007, and will accordingly send it to the XSDValidator however XSD validator is not working
    public class PathController : Controller
    {
        JsonDraft007 jsonDraft007 = new JsonDraft007();
        
        [NonAction]
        // gets the URI from the other controllers and sends it to jsonDraft007, and will accordingly send it to the XSDValidator however XSD validator is not working
        public String GetUri()
        {

            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            var pathValue = httpContextAccessor.HttpContext.Request.Path.Value;
            var pathString = httpContextAccessor.HttpContext.Request.QueryString;

            var path = pathValue + pathString;

            return path;

        }
        // checks and validates whether the form is XML or JSON
        public void validateXMLorJSON(String path,String schemaName)
        {
            if (path.Contains(".json") == true)
            {

               jsonDraft007.jSchemaPath(schemaName);
                
                jsonDraft007.validateJson(path);
                
            }
            else if (path.Contains(".xml") == true)
            {
                // add xml here
            }
            else
            {
                Console.WriteLine("Invalid file type(not xml or json)");
            }

           
        }
    }
}
