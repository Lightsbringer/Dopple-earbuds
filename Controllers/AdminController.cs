using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace SignUp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AddInstruction()
        {
            return View();
        }
        public IActionResult UpdateInstruction()
        {
            return View();
        }
        public IActionResult Order()
        {
            return View();
        }
        public IActionResult Report()
        {
            return View();
        }
        public IActionResult CreateUser()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StationManager() 
        {
            return View();
        }
        public IActionResult StationReport()
        {
            List<StationReport> stations = new List<StationReport>();
            stations.Add(new StationReport { Station = 1, Status = "Active", UserLoggedIn = true });
            stations.Add(new StationReport { Station = 2, Status = "Inactive", UserLoggedIn = false });
            stations.Add(new StationReport { Station = 3, Status = "Inactive", UserLoggedIn = true });
            return View(stations);
        }
    }
}
