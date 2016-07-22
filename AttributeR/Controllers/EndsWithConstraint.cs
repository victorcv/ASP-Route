using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace AttributeR.Controllers
{
    public class EndsWithConstraint: IRouteConstraint
    {
        private readonly string _substr;
        public EndsWithConstraint(string substr)
        {
            _substr = substr;
        }

        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {

            return values.ContainsKey(parameterName)
                    && values[parameterName].ToString().EndsWith(_substr);


        }
    }
}