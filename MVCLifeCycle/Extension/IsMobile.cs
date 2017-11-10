using System.Reflection;
using System.Web.Mvc;

namespace MVCLifeCycle.Extension
{
    public class IsMobile:ActionMethodSelectorAttribute
    {
        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            return controllerContext.HttpContext.Request.Browser.IsMobileDevice;
        }
    }
}