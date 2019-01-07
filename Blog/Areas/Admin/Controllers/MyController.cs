using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Blog.DAL;
using Blog.Model;
using System.Net.Http.Headers;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
namespace Blog.Areas.Admin.Controllers
{
    public class MyController : Controller
    {
        string UserName = string.Empty;
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            UserName = HttpContext.Session.GetString("User");
            if (string.IsNullOrEmpty(UserName))
            {
                HttpContext.Response.Redirect("/Admin/Home/UserLogin");
            }

            base.OnActionExecuting(context);
        }
    }
}
