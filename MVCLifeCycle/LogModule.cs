using System;
using System.Diagnostics;
using System.Web;
using MVCLifeCycle.Handlers;

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
            context.MapRequestHandler += Context_MapRequestHandler;
            context.PreRequestHandlerExecute += Context_PreRequestHandlerExecute;
            context.PostMapRequestHandler += Context_PostMapRequestHandler;
        }

        private void Context_MapRequestHandler(object sender, EventArgs e)
        {
            Debug.WriteLine($"Map Request Handler");;
        }

        private void Context_PostMapRequestHandler(object sender, EventArgs e)
        {
            Debug.WriteLine($"Post Map requeset");
        }

        private void Context_PreRequestHandlerExecute(object sender, EventArgs e)
        {
            Debug.WriteLine($"Pre Requset Handler Execute"); 
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
            if (context.Request.Path.Contains("test.ddd"))
            {
                HttpContext.Current.RemapHandler(new SampleHandler());
                //try
                //{
                //    //context.Response.Write("<h1> My god</h1>");
                //    context.Response.Redirect("abc.axd");
                //    //https://stackoverflow.com/a/22363396/288936
                //    //將Buffer中的內容送出
                //    //HttpContext.Current.Response.Flush();
                //    //忽視之後透過Response.Write輸出的內容
                //    //HttpContext.Current.Response.SuppressContent = true;
                //    //忽略之後ASP.NET Pipeline的處理步驟，直接跳關到EndRequest
                //    HttpContext.Current.ApplicationInstance.CompleteRequest();
                //}
                //catch (Exception ex)
                //{
                //    Debug.WriteLine($" Exception: {ex.Message}");
                    
                //}

                
            }
        }

        public void Dispose()
        {
            //throw new System.NotImplementedException();
        }
    }
}