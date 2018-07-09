using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//


namespace portfolioII.Controllers
{
    public class PortfolioController : Controller
    {
        // A GET method
        [HttpGet]
        [Route("home")]
        public IActionResult homepage()
        {
            return View("homepage");
        }

        [HttpGet]
        [Route("projects")]
        public IActionResult projectsPage()
        {
        
            return View("projects");
        }
        
        [HttpGet]
        [Route("contact")]
        public IActionResult contactPage()
        {
            // return View();
            //OR

            return View("contact");
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