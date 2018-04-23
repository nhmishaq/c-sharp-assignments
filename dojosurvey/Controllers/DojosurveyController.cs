using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace dojosurvey.Controllers
{
    public class DojosurveyController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("survey");
        }

        [HttpPost]
        [Route("/result")]
        public IActionResult result(string Name, string Location, string Language, string Comments)
        {
            ViewBag.name = Name;
            ViewBag.location = Location;
            ViewBag.language = Language;
            ViewBag.comment = Comments;
            return View("results");
        }
    }
}