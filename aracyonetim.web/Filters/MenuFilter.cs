using System.Collections.Generic;
using System.Linq;
using aracyonetim.entities.Dtos;
using aracyonetim.web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace aracyonetim.web.Filters
{
    public class MenuFilter: ActionFilterAttribute
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
                context.Result =new  RedirectResult("/Account/Login");
            }
        }
    }
}