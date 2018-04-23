using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
//
using DbConnection;

namespace quoting_dojo.Controllers
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
        [Route("quotes")]
        public IActionResult postQuote(string name, string quote)
        {
            //Assignment is working; data is being stored in mySQL DB, however the issue is using a dictionary to store the values. 
            //I wasn't sure how to format the parameters in the query. Also in quotesss.cshtml, unpacking the dictionary correctly would 
            //be the final task. 
            DbConnector.Execute("INSERT INTO quotes (name, quote, created_at) VALUES ('{name}', '{quote}', now())");
            List<Dictionary<string, object>> quotedQu = DbConnector.Query("SELECT idquotes, name, quote, created_at FROM quotes");
            ViewBag.quotedQu =quotedQu;
            return View("quotesss");
        }

        [HttpGet]
        [Route("quotes")]
        public IActionResult getQuotes()
        {
            string query = "SELECT idquotes, name, quote, created_at FROM quotes";
            var quotedQu = DbConnector.Query(query);   
            ViewBag.quotedQu =quotedQu;
            return View("quotesss");
        }
    }
}
