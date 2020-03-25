using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TesterClubPagoApi.Filters
{
    public class SecurityFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var h = context.HttpContext.Request.Headers;

            if (h["X-Origin"].ToString() != Utilities.Misc.GetAuthToken())
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                context.Result = new JsonResult(new { codigo = 1, mensaje = "Token Inválido" });
                return;
            }

            if (h["User-Agent"].ToString() != Utilities.Constants.USERAGENT)
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                context.Result = new JsonResult(new { codigo = 2, mensaje = "Origen Desconocido" });
                return;
            }

            base.OnActionExecuting(context);
        }
    }
}
