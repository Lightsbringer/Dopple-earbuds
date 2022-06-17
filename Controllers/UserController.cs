using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApplication3;
using WebApplication3.APIDTOs;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class UserController : Controller
      
    {
        List<UserPage> userdata = new List<UserPage>();


       
        [HttpPost]
        public IActionResult UserPage(UserPage model)
         {
          
                var api = new ApiHandler();
                var instruction = api.GetInstructionsFromApiByStationId(model.StationId);
                model.Description = instruction.Description;
                model.StationId = instruction.StationId;
                model.InstructionId = Convert.ToInt32(instruction.InstructionId);
            
                return View("UserPage", model);
        
            
        }
        public IActionResult UserPage()
        {
            return View();
        }
        
            public IActionResult Index()
        {

            return View();
        }
       
    }
}
