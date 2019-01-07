using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Blog.DAL;
using Blog.Model;
using Microsoft.AspNetCore.Http;
namespace Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SystemController : Controller
    {
        AdminDAL _AdminDAL;

        public SystemController(AdminDAL adminDAL)
        {
            _AdminDAL = adminDAL;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UserInfo()
        {
            return View();
        }

        public IActionResult ChangePassWord()
        {
            string UserName = HttpContext.Session.GetString("User");
            Blog.Model.Admin admin = new Model.Admin();
            if (UserName != null)
            {
                admin = _AdminDAL.GetOneByUserName(UserName);
            }
            else
            {
                return Redirect("/Admin/Home/UserLogin");
            }
            return View(admin);
        }

        [HttpPost]
        public IActionResult ChangePassWord(string passWord)
        {
            string UserName = HttpContext.Session.GetString("User");
            Blog.Model.Admin admin = new Model.Admin();
            if (UserName != null)
            {
                admin = _AdminDAL.GetOneByUserName(UserName);
                admin.APassword = passWord;
                if (_AdminDAL.Update(admin))
                {
                    return Json(new { state = "y", msg = "密码修改成功！，请重新登入" });
                }
                return Json(new { state = "n", msg = "密码修改失败！。请联系管理员" });
            }
            else
            {
                return Redirect("/Admin/Home/UserLogin");
            }

        }
    }
}