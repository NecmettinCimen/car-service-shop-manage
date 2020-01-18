using aracyonetim.web.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace aracyonetim.web.Filters
{
    public class UserFilter: ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var userid = context.HttpContext.Session.GetInt32("userid");
            if (!userid.HasValue)
            {
                context.Result =new  RedirectResult("/Account/Login");
            }
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
        }
    }
}