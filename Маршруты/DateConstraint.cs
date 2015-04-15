using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Маршруты
{
    public class DateConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            DateTime d;
            return DateTime.TryParse(values[parameterName].ToString(), out d);
        }
    }
}