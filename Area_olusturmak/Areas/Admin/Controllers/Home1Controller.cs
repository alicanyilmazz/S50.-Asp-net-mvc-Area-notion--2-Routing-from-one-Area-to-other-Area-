using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Area_olusturmak.Areas.Admin.Controllers
{
    public class Home1Controller : Controller
    {
        // GET: Admin/Home1
        public ActionResult Index()
        {
            return RedirectToAction("Index","Home2",new { area="Customer",alican=5}); //With routeValues
            //return RedirectToAction("Index", "Home2", new { area = "Customer"});    //Without routeValues
        }
    }
}