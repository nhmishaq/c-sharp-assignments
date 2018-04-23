using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace first_asp_assignment.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("deeznuts")]
        public string Index()
        {
            return ("BEENUS DEEZ  NUTS!");
        }

        [HttpGet]
        [Route("")]
        public string DisplayOptions()
        {
            return "Use the following URL options for the app, /firstname, /lastname, /age, /favcolor. Each will return my info.";
        }
        
        [HttpGet]
        [Route("firstname")]
        public JsonResult DisplayFirstName()
        {
            return Json("Tim");
        }
        [Route("lastname")]
        public JsonResult DisplayLastName()
        {
            return Json("Toolman");
        }
        [Route("age")]
        public JsonResult DisplayAge()
        {
            return Json("42");
        }
        [Route("favcolor")]
        public JsonResult DisplayFavColor()
        {
            return Json("Brown");
        }
        [HttpGet]
        [Route("{firstName}/{lastName}/{age}/{faveColor}")]
        public JsonResult Jsonify(string firstName, string lastName, int age, string faveColor)
        {
          var callCard = new {
            FirstName = firstName,
            LastName = lastName,
            Age = age,
            FaveColor = faveColor
          };
          return Json(callCard);
        }
    }
}
// Copy
// This simple controller sends a string to be displayed in the browser.

