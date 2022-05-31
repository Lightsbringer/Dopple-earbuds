using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
