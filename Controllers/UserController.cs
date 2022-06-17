using DoppleMessages;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebApplication3;
using WebApplication3.Models;

namespace SignUp.Controllers
{
    public class UserController : Controller
      
    {
        List<UserPage> userdata = new List<UserPage>();

        public IActionResult UserPage()
        {
            var api = new ApiHandler();
            var station = api.GetStationFromAPI();
            List<InstructionEntity> instructions = api.GetInstructionsFromApi();
            return View(instructions);
        }

            public IActionResult Index()
        {

            return View();
        }
       
    }
}
