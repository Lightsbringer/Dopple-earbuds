using Microsoft.AspNetCore.Mvc;
using WebApplication3.View_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class AccountController1 : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login(UserLogin userLogin)
        {
            if(userLogin.UserID == "insert user id here" && userLogin.Password == "insert user password here")
            {
                return View("UserPage", userLogin);
            }
            else
            {
                return View("Login", userLogin);
            }
            
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
