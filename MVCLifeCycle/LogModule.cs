using System;
using System.Diagnostics;
using System.Web;

namespace MVCLifeCycle
{
    public class LogModule:IHttpModule
    {
        public void Init(HttpApplication context)
        {
            //throw new System.NotImplementedException();
            Debug.WriteLine("~~~~~~~~~~~~");
            context.BeginRequest +=
                (new EventHandler(this.Application_BeginRequest));
            context.EndRequest +=
                (new EventHandler(this.Application_EndRequest));
        }

        private void Application_EndRequest(object sender, EventArgs e)
        {
            var context =((HttpApplication) sender).Context;
            Debug.WriteLine($"{context.Request.Path} End Request");
           
        }

        private void Application_BeginRequest(object sender, EventArgs e)
        {
            var context = ((HttpApplication)sender).Context;
            Debug.WriteLine($"{context.Request.Path} Begin Request");
        }

        public void Dispose()
        {
            //throw new System.NotImplementedException();
        }
    }
}