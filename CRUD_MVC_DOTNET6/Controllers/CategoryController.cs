using Microsoft.AspNetCore.Mvc;
using CRUD_MVC_DOTNET6.Models;
using CRUD_MVC_DOTNET6.Data;

namespace CRUD_MVC_DOTNET6.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
             _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);  
        }
        public IActionResult Create()
        {
            return View();
        }


        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if(ModelState.IsValid)
            {
                _db.Categories.Add(category);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        public IActionResult Edit(int? id)
        {
            if(id == null || id==0)
            {
                return NotFound();  
            }
            var categoryFromDb = _db.Categories.Find(id);

            if(categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);  
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(category);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.Categories.Find(id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Remove(category);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }
    }
}
