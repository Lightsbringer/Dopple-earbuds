using Microsoft.AspNetCore.Mvc;
using SignUp.View_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace SignUp.Controllers
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
            
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
