using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Demo.Constraints
{
    public class NotEqual : IRouteConstraint
    {
        string value1;
        public NotEqual(string value)
        {
            value1 = value;
        }
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            bool result;

            result = string.Compare(values[parameterName].ToString(), value1) != 0;

            return result;
        }
    }
}