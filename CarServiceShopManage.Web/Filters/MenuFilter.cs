using System.Collections.Generic;
using System.Linq;
using CarServiceShopManage.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace CarServiceShopManage.Web.Filters
{
    public class MenuFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var mentstr = context.HttpContext.Session.GetString(Metrics.SessionKeys.MenuAdresler);
            var menulist = JsonConvert.DeserializeObject<List<string>>(mentstr).ToList();

            var controllerName = ((ControllerBase)context.Controller)
                .ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ((ControllerBase)context.Controller)
                .ControllerContext.ActionDescriptor.ActionName;

            if (!menulist.Contains(controllerName.ToLower()))
            {
                context.Result = new RedirectResult("/Account/Login");
            }
        }
    }
}