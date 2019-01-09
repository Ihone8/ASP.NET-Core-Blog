using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Blog.Models;
using Blog.Model;
using Blog.DAL;
using Microsoft.AspNetCore.Http;
namespace Blog.Controllers
{
    public class HomeController : Controller
    {

        AdminDAL _AdminDAL;
        CategoryDAL _CATEGORYDAL;
        BlogDAL _BlogDAL;
        public HomeController(AdminDAL adminDAL, CategoryDAL categoryDAL, BlogDAL blogDAL)
        {
            _AdminDAL = adminDAL;
            _CATEGORYDAL = categoryDAL;
            _BlogDAL = blogDAL;
        }
        public IActionResult Index()
        {
            ViewBag.CategoryList = _CATEGORYDAL.GetList();
            ViewBag.BlogDAL = _BlogDAL;
            return View();
        }


        public IActionResult ShowBlogDetails(int? Id)
        {
            ViewBag.CategoryList = _CATEGORYDAL.GetList();
            ViewBag.BlogDAL = _BlogDAL;
            if (Id == null)
            {
                return Content("找不到该条博客数据！");
            }
            else
            {
                BLOG bLOG = _BlogDAL.GetOne(Id.Value);
                if (bLOG == null)
                {
                    return Content("找不到该条博客数据！");
                }
                bLOG.Visit += 1;
                _BlogDAL.Update(bLOG);
                return View(bLOG);
            }
        }     

    }
}
