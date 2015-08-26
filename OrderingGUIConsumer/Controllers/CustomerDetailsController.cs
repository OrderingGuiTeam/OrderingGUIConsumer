using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderingGUIConsumer.Models;

namespace OrderingGUIConsumer.Controllers
{
    public class CustomerDetailsController : Controller
    {
        // GET: CustomerDetails
        public ActionResult Details()
        {
            return View();
        }

        public String ToState(string strFirstName, string strLastName, string strAddress, string strLocation)
        {            
            DetailsModel objDetailsModel = new DetailsModel();
            return objDetailsModel.insertDetails(strFirstName, strLastName, strAddress, strLocation);            
        }
    }
}