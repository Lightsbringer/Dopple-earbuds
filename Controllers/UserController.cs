using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication3;
using WebApplication3.APIDTOs;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class UserController : Controller
      
    {
        List<UserPage> userdata = new List<UserPage>();

        //this is for the input 
        //[]
        public IActionResult UserPage(InstructionEntity _instruction, OperatorEntity _operator,StationEntity _stationEntity)
        {
            
            var api = new ApiHandler();
            var station = api.GetStationFromApiByStationId(_stationEntity.StationId);
            var instruction = api.GetInstructionsFromApiByStationId(_instruction.StationId);
            UserPage userPage = new UserPage(station,instruction,_operator);
            
            return View("UserPage", userPage);
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
