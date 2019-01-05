using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Blog.DAL;
using Blog.Model;
namespace Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryDAL _CategoryDAL;
        public CategoryController(CategoryDAL categoryDAL)
        {
            _CategoryDAL = categoryDAL;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add(int? Id)
        {

            var Category = new CATEGORY();
            if (Id != null)
            {
                Category = _CategoryDAL.GetOne(Id.Value);
            }
            return View(Category);
        }


        [HttpPost]
        public IActionResult Add(CATEGORY CATEGORY)
        {
            if (CATEGORY.Id == 0)
            {
                _CategoryDAL.Add(CATEGORY);
            }
            else
            {
                _CategoryDAL.Update(CATEGORY);
            }
            return Redirect("/Admin/Category/Index");
        }
        /// <summary>
        ///  获取分类总数量
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult GetCategoryListTotal()
        {
            var Total = _CategoryDAL.GetCount();

            return Content(Total.ToString());
        }

        /// <summary>
        ///  根据分页获取类型数据
        /// </summary>
        /// <param name="PageIndex">页码</param>
        /// <param name="PageSize">页面显示多少条</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult GetCategorListByPaging(int PageIndex, int PageSize)
        {
            var CategoryList = _CategoryDAL.GetList();
            var list = CategoryList.Skip(PageSize * PageIndex).Take(PageSize).ToList();
            return Json(new { data = list });
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {
            if (_CategoryDAL.Delete(Id))
            {
                return Content("删除成功！");
            }
            return Content("删除失败！.请联系管理员。");
        }

    }
}