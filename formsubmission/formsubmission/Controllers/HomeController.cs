using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
//
using formsubmission.Models;


namespace formsubmission.Controllers
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

        [HttpGet]
        [Route("/register")]
        public IActionResult success(string firstname, string lastname, int age, string email, string password)
        {
            User NewUser = new User{
                FirstName = firstname,
                LastName = lastname,
                Age = age,
                Email = email,
                Password = password
            };
            TryValidateModel(NewUser);
            if (ModelState.IsValid){
                return View("success");
            } else {
                ViewBag.Errors = ModelState.Values;
                return View("index");
            }     
        }
    }
}
