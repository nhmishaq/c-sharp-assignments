using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DbConnection;


namespace simple_crud.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            // DbConnector.Execute ("INSERT INTO Users(FirstName, LastName, FavoriteNumber) VALUES (JamisonTHEFOURTH, Crowder, 80)");
            // DbConnector.Query("SELECT idUsers, FirstName, LastName, FavoriteNumber FROM Users");

            return View();
        }


    }
}
