using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
using WebApplication3;
using WebApplication3.APIDTOs;
using System.Diagnostics;

namespace WebApplication3.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AddInstruction()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddInstruction(AddInstruction model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("AddInstruction");
            }
            return View();
        }
        public ActionResult AddStation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStation(AddStation model)
        {
            if (ModelState.IsValid)
            {
                var api = new ApiHandler();
                bool requestingUser = api.AddStation(model.StationId);
                //looking if the userId is in the database
                if (requestingUser)
                {
                    Debug.WriteLine("Station Added");
                    return RedirectToAction("StationReport", model.StationId);
                }
                else
                {
                    Debug.WriteLine("Failed to add station");
                    return RedirectToAction("StationManager");
                }
            }
            else
            {
                return RedirectToAction("AddStation");
            }

        }
        [HttpPost]
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
            var api = new ApiHandler();
            var stations = api.GetAllStationFromApi();
            return View(stations);
        }
        public IActionResult StationReport(int id)
        {
            var api = new ApiHandler();
            var station = api.GetStationFromApiByStationId(id);
            return View(station);
        }

        public IActionResult Update(int id, string status)
        {
                var api = new ApiHandler();
                bool result = api.UpdateStationStatusFromApiById(id, status);
                if (result)
                {
                    Debug.WriteLine("updated status: " + status);
                    return RedirectToAction("StationReport", id);
                }
                else {
                    Debug.WriteLine("no update");
                    return RedirectToAction("StationReport", id);
            }
        }

        public IActionResult StationDelete(int id)
        {
            if (ModelState.IsValid)
            {
                var api = new ApiHandler();
                bool result = api.DeleteStationFromApiById(id);
                if (result)
                {
                    Debug.WriteLine("deleted");
                    return RedirectToAction("StationManager");
                }
                else
                {
                    Debug.WriteLine("no delete station");
                    return RedirectToAction("StationManager");
                }
            }
            return RedirectToAction("StationManager");

        }
    }
}
