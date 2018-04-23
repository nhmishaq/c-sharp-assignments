using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
//
using login_registration.Models;
// using DbConnector;


namespace login_registration.Controllers
{
    public class HomeController : Controller
    {
        private readonly DbConnector _dbConnector;
 
        public HomeController(DbConnector connect)
        {
            _dbConnector = connect;
        }

        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        public IActionResult createThis(User user){
            TryValidateModel(user);
            ViewBag.errors = ModelState.Values;
            
            if(ModelState.IsValid)
            {
            _dbConnector.Execute($"INSERT INTO User (first_name, last_name, email, password) VALUES ('{user.first_name}', '{user.last_name}', '{user.email}', '{user.password}')");
            List<Dictionary<string, object>> quotedQu = _dbConnector.Query($"SELECT idUser, first_name, last_name, email, password FROM User");
                ViewBag.quotedQu = quotedQu;
                return View("dashboard");
            }
            else {
                return View("postQuote");
            }
            // return View(user);
        }

        [HttpPost]
        [Route("delete")]
        public IActionResult delete(User user)
        {
            List<Dictionary<string, object>> quotedQu = _dbConnector.Query($"SELECT idUser, first_name, last_name, email, password FROM User");
            ViewBag.quotedQu = quotedQu;
            _dbConnector.Execute($"DELETE FROM User WHERE email = '{user.email}'");
            return View("dashboard");
        }

        //The "legitUser" query is supposed to return null if the email/pw entered isn't in the db, h.e. the if-statement isn't catching
        //the null fail to redirect it to "postQuote.cshtml". Instead, its accepting null values as valid and the else clause executes; rendering
        //the dashboard page
        [HttpPost]
        [Route("login")]
        public IActionResult login(User user)
        {
            List<Dictionary<string, object>> legitUser = _dbConnector.Query($"SELECT idUser, first_name, last_name FROM User WHERE email = '{user.email}' && password = '{user.password}'");
            if (legitUser.Contains(null)){
                TryValidateModel(user);
                ViewBag.errors = ModelState.Values;
                return View("postQuote");
            }
            else {
                List<Dictionary<string, object>> quotedQu = _dbConnector.Query($"SELECT idUser, first_name, last_name, email, password FROM User");
                ViewBag.quotedQu = quotedQu;
                return View("dashboard");
            }
            
        }

        [HttpGet]
        [Route("logouts")]
        public IActionResult logout()
        {
            ModelState.Clear();
            return View("Index");
        }

    }
}