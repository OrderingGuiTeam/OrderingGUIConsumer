using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderingGUIConsumer.Models;

namespace OrderingGUIConsumer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string agentName="")
        {
            ViewBag.agentName = "Welcome " + agentName;
            return View();
        }
        public ActionResult LoginStartPage()
        {
            return View();
        }
    }
}