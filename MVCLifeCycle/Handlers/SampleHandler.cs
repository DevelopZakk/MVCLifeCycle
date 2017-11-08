using System.Web;

namespace MVCLifeCycle.Handlers
{
    public class SampleHandler: IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("<p> this is a test ... from sample handler </p>");
        }

        public bool IsReusable => false;
    }
}