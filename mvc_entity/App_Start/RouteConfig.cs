using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using mvc_entity.Models;
using mvc_entity.Dataaccess;

namespace mvc_entity
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            
            routes.MapRoute(
                name: "Customer",
                url: "EnterData",
                defaults: new { controller = "Customer", action = "Enter"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Customer", action = "Index", id = UrlParameter.Optional }
            );
        }
        //protected void Application_Start(object sender, EventArgs e)
        //{
        //    studentdal s1 = new studentdal();
        //    student stud1 = new student()
        //    {
        //        id = 10,
        //        name = "Test1"
        //    };
        //    s1.stud.Add(stud1);
        //    s1.SaveChanges();
        //}
    }
}
