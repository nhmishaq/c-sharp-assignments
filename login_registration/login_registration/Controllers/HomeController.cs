using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using login_registration.Models;
//
using DbConnection;

namespace login_registration.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        public IActionResult create(string First_Name, string Last_Name, string Email, string Password, string Password_Confirm)
        {
            User NewUser = new User
            {
                first_name = First_Name,
                last_name = Last_Name,
                email = Email,
                password = Password

            };
            TryValidateModel(NewUser);
            ViewBag.errors = ModelState.Values;
        return View();
        }
    }
}
