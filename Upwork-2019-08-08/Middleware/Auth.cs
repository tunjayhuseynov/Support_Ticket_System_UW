using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Upwork_2019_08_08.Middleware
{
    public class Auth : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.HttpContext.Session.GetString("LogedIn") == null)
            {
                context.Result = new RedirectResult("~/Sign");

            }
            base.OnActionExecuted(context);
        }
    }
}
