using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace callingCard.Controllers
{
    public class HelloController : Controller
    {
        // A GET method that returns a string
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "Hello World!";
        }
        
        // A GET method that returns JSON
        [HttpGet]
        [Route("jsonobj")]
        public JsonResult Indexes()
        {
            var pointlessObject = new {
                pointlessName = "Dak",
                pointlessHobby = "play's football for Cowboys",
                age = 88
            };
            return Json(pointlessObject);
        }

        //get route that accepts parameters
        [HttpGet]
        [Route("template/{FirstName}/{LastName}/{age}/{favoriteColor}")]
        public JsonResult Method(string FirstName, string LastName, int age, string favoriteColor)
        {
            var secondPointlessThing = new {
                first = FirstName,
                last = LastName, 
                years = age,
                color = favoriteColor
            };
            return Json(secondPointlessThing);
        }
    }
}
