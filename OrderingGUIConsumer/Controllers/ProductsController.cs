using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderingGUIConsumer.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Json()
        {
            //Employee employee = new Employee();
            //employee.FirstName = "fname";
            //employee.LastName = "last";
            //employee.Salary = 2111;
            //return Json(new JavaScriptSerializer().Serialize(employee),JsonRequestBehavior.AllowGet);
            //return Json(new JavaScriptSerializer().Serialize("hi"),JsonRequestBehavior.AllowGet);

            //getting json from a url
            //WebRequest request = WebRequest.Create("http://api.geonames.org/citiesJSON?north=44.1&south=-9.9&east=-22.4&west=55.2&lang=de&username=demo");
            //WebResponse response = request.GetResponse();
            //StreamReader reader = new StreamReader(response.GetResponseStream());
            //string res = reader.ReadToEnd();

            //getting json from local file
            string result = System.IO.File.ReadAllText(@"C:\Users\Administrator\Documents\Visual Studio 2015\Projects\OrderingGUIConsumer\OrderingGUIConsumer\jsonfile\Products.json");

            //JavaScriptSerializer serializer = new JavaScriptSerializer();
            //string json = serializer.Serialize<Rootobject2>(result);

            //now revert it back as objects
            //Geoname names = serializer.Deserialize<Geoname>(json);
            //return names;
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}