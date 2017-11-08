using System;
using System.Diagnostics;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MVCLifeCycle;

//[assembly:PreApplicationStartMethod(typeof(Global),"Register")]

namespace MVCLifeCycle
{
    public class Global : HttpApplication
    {

        public static void Register()
        {
            HttpApplication.RegisterModule(typeof(LogModule));
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Debug.WriteLine("Session Start");
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

            Debug.WriteLine("Begin Request");
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            Debug.WriteLine("Authenticate Request");
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Debug.WriteLine("Application Error");
        }

        protected void Application_ResolveRequestCache(object sender, EventArgs e)
        {
            Debug.WriteLine("URL routing Module, resolve request cache");
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            Debug.WriteLine("End Request");
        }

        protected void Session_End(object sender, EventArgs e)
        {
            Debug.WriteLine("Session End");
        }

        protected void Application_End(object sender, EventArgs e)
        {
            Debug.WriteLine("****************Application Down***********");
        }
    }
}