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


        //  

        /// <summary>
        ///  获取博客总数量
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult GetBlogListTotal()
        {
            var Total = _BlogDAL.GetCount();

            return Content(Total.ToString());
        }

        /// <summary>
        ///  根据分页获取博客数据
        /// </summary>
        /// <param name="PageIndex">页码</param>
        /// <param name="PageSize">页面显示多少条</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult GetBlogListByPaging(int PageIndex, int PageSize)
        {
            var BlogList = _BlogDAL.GetList();
            var list = BlogList.Skip(PageSize * PageIndex).Take(PageSize).ToList();

            return Json(new { data = list });
        }


    }
}
