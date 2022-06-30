using Microsoft.AspNetCore.Mvc;

namespace DoppleApi.Controllers
{
    //this clas is used for validation purposes
    // it gets the path from the other controllers and sends it to jsonDraft007, and will accordingly send it to the XSDValidator 
    //this class is working , but not used
    public class PathController : Controller
    {
        JsonDraft007 jsonDraft007 = new JsonDraft007();
        [NonAction]
        public String GetUri()
        {
            //var message = HttpContext.Request.Path.Value;
            // var message1 = HttpContext.Session.GetString;
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            var ok = httpContextAccessor.HttpContext.Request.Path.Value;

            var ok2 = httpContextAccessor.HttpContext.Request.QueryString;
            var ok3 = httpContextAccessor.HttpContext.Request.Query;
            var ok4 = httpContextAccessor.HttpContext.Request.QueryString.Value;
            var ok5 = httpContextAccessor.HttpContext.Request.QueryString.HasValue;
            var ok6 = httpContextAccessor.HttpContext.Request.Headers;
            var ok7 = httpContextAccessor.HttpContext.Request.HasFormContentType;
            var ok8 = httpContextAccessor.HttpContext.Request.Body;
            var ok9 = httpContextAccessor.HttpContext.Request.BodyReader;
            var ok10 = httpContextAccessor.HttpContext.Request.Scheme;

            // var ok3 = ok + ok2;


            // Console.WriteLine(ok3);
            Console.WriteLine(ok3);

            Console.WriteLine(ok10);
            Console.WriteLine(ok6);

            return ok;

        }
        public void validateXMLorJSON(int number,String path)
        {
            if (number == 0)
            {

                jsonDraft007.jSchemaPath("Carrier");
                
                jsonDraft007.random(path);
                
            }
        }            
    }
}
