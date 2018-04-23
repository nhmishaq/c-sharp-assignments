using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace timedisplay.Controllers
{
    public class time : Controller
    {
        [HttpGet]
        [Route("index")]
        public string IndexA()
        {
            return "Hello World!";
        }
        
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
