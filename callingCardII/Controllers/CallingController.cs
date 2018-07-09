using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace callingCardII.Controllers
{
    public class CallingController : Controller
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
        
        // A POST method
        [HttpGet]
        [Route("{first}/{last}/{age}/{color}")]
        public JsonResult JsonMethod(string first, string last, int age, string color)
        {
           var AnonObject = new {
                        FirstName = first,
                        LastName = last,
                        Age = age,
                        Color = color
                     };
            return Json(AnonObject);
        }

    }
}