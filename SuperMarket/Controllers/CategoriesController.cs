using Microsoft.AspNetCore.Mvc;
using SuperMarket.Models;

namespace SuperMarket.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Shopnow()
        {
            var categories = CategoriesRepositoryModel.GetCategoryModels();
            return View(categories);
        }

      
        public IActionResult Edit(int? id)
        {
            var category = new CategoryModel{CategoryId = id.HasValue?id.Value : 0};

            return View(category);
        }
    }
}
