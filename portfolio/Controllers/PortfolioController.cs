using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        [HttpGet]
        [Route("/home")]
        public IActionResult Index()
        {
            return View("home");
            //Both of these returns will render the same view (You only need one!)
        }

        [HttpGet]
        [Route("/projects")]
        public IActionResult Projects()
        {
            return View("projects");
            //Both of these returns will render the same view (You only need one!)
        }

        [HttpGet]
        [Route("/contact")]
        public IActionResult Contact()
        {
            return View("contact");
            //Both of these returns will render the same view (You only need one!)
        }
        // [HttpGet]
        // [Route("index")]
        // public string Index()
        // {
        //     return "Hello World!";
        // }

        // // A POST method
        // [HttpPost]
        // [Route("")]
        // public IActionResult Other()
        // {
        //     // Return a view (We'll learn how soon!)
        // }

    }
}
