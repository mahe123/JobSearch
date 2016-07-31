using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoMaTellerMachine.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        [Route("Home/About")]
        public ActionResult Index()
        {
            return View("CarousalTemplate");
        }
        
        public ActionResult About()
        {
            ViewBag.MessageAbout = "Your application description page.";

            return View();
        }
        
        public ActionResult Contact()
         {
            ViewBag.MessageContact = "Having Trouble ? send us a Message";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.MessageContact = "Thanks,we got Your Message!";

            return View();
        }

        public ActionResult Serial(String letterCase)
        {
            var Serial = "ASPNETMVCATM1";
            if (letterCase == "lower")
            {
                return Content(Serial.ToLower());
            }
            return Json(new { name = "Serial", Value = Serial }, JsonRequestBehavior.AllowGet);
        }
           }
}