using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Upwork_2019_08_08.Areas.adminpanel.Middleware
{
    public class AdminAuth : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.HttpContext.Session.GetString("AdminLogedIn") == null)
            {
                context.Result = new RedirectResult("~/adminpanel/AdminSign");

            }
            base.OnActionExecuted(context);
        }
    }
}
