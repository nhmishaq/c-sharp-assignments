using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//


namespace dojoSurvey.Controllers
{
    public class dojoSurveyController : Controller
    {
        // A GET method
        [HttpGet]
        [Route("")]
        public IActionResult homepage()
        {
            return View("dojoSurvey");
        }

        // [HttpGet]
        // [Route("projects")]
        // public IActionResult projectsPage()
        // {
        
        //     return View("projects");
        // }



        // A POST method
        [HttpPost]
        [Route("results")]
        public IActionResult result(string name, string location, string language, string comment)
        {
            ViewBag.Name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.comment = comment;
            return View("results");
        }

    }
}