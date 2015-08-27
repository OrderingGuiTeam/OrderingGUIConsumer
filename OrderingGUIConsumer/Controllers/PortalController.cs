using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderingGUIConsumer.Models;

namespace OrderingGUIConsumer.Controllers
{
    public class PortalController : Controller
    {

        public ActionResult Index()
        {
            PortalModel details = new PortalModel();
            PortalModel getobj = new PortalModel();
            details = getobj.GetUsers();

            return View(details);
        }
        //[HttpGet]
        //public ActionResult addDetails()
        //{
        //    return View();
        //}
        [HttpPost]
        public ActionResult Index(string email,string mobile,string bfname,string blname,string bstr,string bzip, string bcity,string bstate,string bstateid,string bcountry, string bdob, string sfname, string slname, string sstr,string szip,string scity, string sstate,string sstateid, string scountry,string sdob,string duedate)
        {
            PortalModel newmv = new PortalModel();
            PortalModel obj = new PortalModel();
        
            
            newmv.Email = email;
            newmv.Phone = Convert.ToInt64(mobile);
            newmv.Billfname = bfname;
            newmv.Billlname = blname;
            newmv.Billstreet = bstr;
            newmv.Billzipcode = Convert.ToInt32(bzip);
            newmv.Billcity = bcity;
            newmv.Billstate = bstate;
            newmv.Billstateid = Convert.ToInt32(bstateid);
            newmv.Billcountry = bcountry;
            newmv.Billdob = Convert.ToDateTime(bdob);
            newmv.Shipfname = sfname;
            newmv.Shiplname = slname;
            newmv.Shipstreet = sstr;
            newmv.Shipzipcode = Convert.ToInt32(szip);
            newmv.Shipcity = scity;
            newmv.Shipstate = sstate;
            newmv.Shipstateid = Convert.ToInt32(sstateid);
            newmv.Shipcountry = scountry;
            newmv.Shipdob = Convert.ToDateTime(sdob);
            newmv.Bookdate = DateTime.Today;
            newmv.Duedate = Convert.ToDateTime(duedate);
            //document.getElementById("form1").AddUsers();
            //document.getElementById("form2").submit();
            obj.AddUsers(newmv);
            return View();
        }
        [HttpGet]
        public ActionResult ndata()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ndata(FormCollection objform)
        {
            PortalModel newmv = new PortalModel();

            newmv.Email= objform["first_name"];
            newmv.Billlname = objform["last_name"];
            newmv.Billfname= objform["bcountry"];

            PortalModel obj = new PortalModel();
            obj.A(newmv.Email,newmv.Billlname,newmv.Billfname);
            return View();
        }

        //[HttpPost]
        //public ActionResult Index(FormCollection form)
        //{
        //    PortalModel newmv = new PortalModel();
        //    newmv.Email = form["emails"].ToString();
        //    newmv.Phone =Convert.ToInt32(form["telephone"]);

        //    PortalModel obj = new PortalModel();

        //    obj.AddUsers(newmv);
        //    return View();
        //}


        //[HttpGet]
        //public ActionResult Index()
        //{
        //    //int records = deletemodel.Delete(id);
        //    //if (records > 0)
        //    //{
        //    //    return RedirectToAction("Index", "Home");
        //    //}
        //    //else
        //    //{
        //    //    ModelState.AddModelError("", "Can Not Delete");
        //    //    return View("Index");
        //    //}
        //}
    }
}