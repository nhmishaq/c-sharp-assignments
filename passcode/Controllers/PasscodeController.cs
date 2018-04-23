using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
 
namespace passcode.Controllers
{
    public class PasscodeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("passcode", 1);
            int? passcode_int = HttpContext.Session.GetInt32("passcode");
            ViewBag.passcode_int = passcode_int;
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[14];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            ViewBag.Example = finalString;
            return View();
        }

        [HttpGet]
        [Route("method")]
        public IActionResult Method()
        {
            int? passcode_int = HttpContext.Session.GetInt32("passcode");
            HttpContext.Session.SetInt32("passcode", (int)passcode_int + 1);
            int? num = HttpContext.Session.GetInt32("passcode");
            ViewBag.passcode_int = num;

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[14];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            ViewBag.Example = finalString;
            return View();
        }
    }
}