using Demo.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Demo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}/{Name}",
            //    defaults: new { controller = "Default", action = "Index", id = UrlParameter.Optional, Name = UrlParameter.Optional }
            //);

           // routes.MapRoute(
           //    name: "Default",
           //    url: "{controller}/{action}/{id}",
           //    defaults: new { controller = "Default", action = "Index", id = UrlParameter.Optional},
           //    constraints:new {Controller=new NotEqual("admin")}
               
           //);

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Default", action = "print", id = UrlParameter.Optional }
         );
        }
    }
}
