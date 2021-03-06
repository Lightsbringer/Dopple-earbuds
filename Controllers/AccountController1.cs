using Microsoft.AspNetCore.Mvc;
using WebApplication3.View_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
using WebApplication3;

namespace WebApplication3.Controllers
{
    public class AccountController1 : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserLogin model)
        {
            if(ModelState.IsValid)
            {
                var api = new ApiHandler();
                var requestingUser = api.GetOperatorFromApiByOperatorId(model.UserID);
                //looking if the userId is in the database
             
                    int userId = Convert.ToInt32(requestingUser.OperatorId); 
              
                if (model.UserID == userId && model.Password == requestingUser.Password &&requestingUser.Authorization.ToLower() == "admin")
                {
                    return RedirectToAction("AddInstruction");
                }
                else if (model.UserID == userId && model.Password == requestingUser.Password &&requestingUser.Authorization.ToLower() == "operator")
                {
                    return View("UserPage");
                }
                {
                    return RedirectToAction("Login");
                }
                
            }
            else
            {
                return RedirectToAction("Login");
            }
            
        }
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
