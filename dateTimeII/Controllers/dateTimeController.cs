using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace dateTimeII.Controllers
{
    public class dateTimeController : Controller
    {
        // [HttpGetAttribute]
        // public string Index()
        // {
        //     return "Hello World!";
        // }
        // A GET method
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "Hello World!";
        }

        [HttpGet]
        [Route("yooo")]
        public IActionResult IndexII()
        {
            // return View();
            //OR

            DateTime CurrentTime = DateTime.Now;

            return View("Index", CurrentTime);
            //Both of these returns will render the same view (You only need one!)
        }
        
        // A POST method
        // [HttpGet]
        // [Route("{first}/{last}/{age}/{color}")]
        // public JsonResult JsonMethod(string first, string last, int age, string color)
        // {
        //    var AnonObject = new {
        //                 FirstName = first,
        //                 LastName = last,
        //                 Age = age,
        //                 Color = color
        //              };
        //     return Json(AnonObject);
        // }

    }
}