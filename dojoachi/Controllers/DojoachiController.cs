using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

 
namespace dojoachi.Controllers
{
    public class DojoachiController : Controller
    {
        [HttpGet]
        [Route("dojoachi")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("feed")]
        //Problem is in passing object of class Dojoachi type. Intent is to pass object as parameter and use
        //appropriate class methods to manipulate object. Ultimately the object attribute will be displayed in the
        //index method. ViewBag is currently being used to store object value.
        public IActionResult feed(Dojoachi buddy)
        {
            buddy.feed();
            ViewBag.Fullness =  buddy.fullness();
            ViewBag.Meals =  buddy.meals();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("play")]
        public IActionResult play(string name)
        {
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        [Route("work")]
        public IActionResult work(string name)
        {
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("sleep")]
        public IActionResult sleep(string name)
        {
            return RedirectToAction("Index");
        }

    }
}