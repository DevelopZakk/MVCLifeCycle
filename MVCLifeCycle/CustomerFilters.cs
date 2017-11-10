using System.Web;
using System.Web.Mvc;

namespace MVCLifeCycle
{
    public class CustomerFilters1:FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext.Current.Application["Order"] += "Action 1 Excuting <br/>";
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            HttpContext.Current.Application["Order"] += "Action 1 Excuted <br/>";
        }
    }

    public class CustomerFilters2 : FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext.Current.Application["Order"] += "Action 2 Excuting <br/>";
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            HttpContext.Current.Application["Order"] += "Action 2 Excuted <br/>";
        }
    }

    public class CustomerFilters3 : FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext.Current.Application["Order"] += "Action 3 Excuting <br/>";
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            HttpContext.Current.Application["Order"] += "Action 3 Excuted <br/>";
        }
    }
}