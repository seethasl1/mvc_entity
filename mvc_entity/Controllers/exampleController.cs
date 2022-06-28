using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_entity.Controllers
{
    public class exampleController : Controller
    {
        // GET: example
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string Index(string comments)
        {
            return "Your Comments" + comments;
        }
    }
}