using Microsoft.AspNetCore.Mvc;
using WorldDominion.Models;

namespace WorldDominion.Controllers
{
    public class CategoriesController : Controller
    {

        private List<Category> Categories { get; set; }



        public CategoriesController()
        {
            Categories = new List<Category>()
            {
                new Category { Id = 1, Name = "Dairy and Eggs", Description = "Find all the best milks and ovums" },
                new Category { Id = 2, Name = "Fruits and Vegtables", Description = "Lettuce turn up the beet! It's kind of a big dill." },
                new Category { Id = 3, Name = "Meats", Description = "Were a provider of a fine meats." }
            };

        }



        public IActionResult Index()
        {
            return View(Categories);
        }


        public IActionResult Browse(int id)
        {
            {
                var category = Categories.Find(category => category.Id == id);
                return View(category);
            }
        }
    }
}
