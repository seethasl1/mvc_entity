using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_entity.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Method1()
        {
            return Content("Using Method1");
        }
        [ActionName("Action2")]
        public ActionResult Method1(string msg)
        {
            msg = "Using Action Attribute in Method1";
            return Content(msg);

        }
    }
}