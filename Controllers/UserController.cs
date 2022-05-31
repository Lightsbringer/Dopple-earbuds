using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignUp.Controllers
{
    public class UserController : Controller
    {
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
