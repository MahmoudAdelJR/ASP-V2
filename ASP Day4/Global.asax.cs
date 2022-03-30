using ASP_Day4.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP_Day4
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            IOCRegisteration.RegisterIOC();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
