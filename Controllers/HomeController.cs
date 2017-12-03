using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace firstAsp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGetAttribute]
        [Route("")]
        public IActionResult Index()
        {
            int? count = HttpContext.Session.GetInt32("count");
            if(count == null)
            {
                count = 0;
            }
            count += 1;
            Random random = new Random();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string passcode = "";
            for (int i = 0; i < 14; i++)
            {
                passcode = passcode + characters[random.Next(0, characters.Length)];
            }
            ViewBag.passcode = passcode;
            ViewBag.count = count;
            HttpContext.Session.SetInt32("count", (int)count);
            return View();
        }
    }
}