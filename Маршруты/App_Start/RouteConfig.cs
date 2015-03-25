using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Маршруты
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
             
            routes.MapRoute(
                name: "home",
                url: "",
                defaults: new { controller = "Home", action = "products",  }
            );

             routes.MapRoute(
               name: "article",
               url: "product/{article}",
               defaults: new { controller = "Product", action = "Index", name = "AB-123" },
                  constraints: new { 
                      name = "[A-Z]{2}-[0-9]{3}"
                  }
               );
             /*print*/
             routes.MapRoute(
                 name: "Print",
                 url: "product/{article}/Print",
                 defaults: new { controller = "Product", action = "Print", name = "AB-123" },
                    constraints: new
                    {
                        name = "[A-Z]{2}-[0-9]{3}"
                    }
                 );

             /*category*/
             routes.MapRoute(
               name: "Category",
               url: "products/{Category}/{page}",
               defaults: new { controller = "Product", action = "Category", category = "Cars", page = "1" },
                  constraints: new
                  {
                      category = "[a-z]+",
                      page = "[0-9]+"
                  }
               );
             /*date*/
             /* xxxx-xx-xx - валидная дата*/
             routes.MapRoute(
               name: "ProductDate",
               url: "products/date/{date}/{page}",
               defaults: new { controller = "Product", action = "Date", date = "24.03.2015", page = "1" },
                  constraints: new
                  {
                      date = @"(0[1-9]|[12][0-9]|3[01])[-](0[1-9]|1[012])[-](19|20)\d\d",
                      page = "[0-9]+"
                  }
               );

             routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
