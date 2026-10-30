using Bai3_Dinh_Tuan.Models;
using Bai3_DinhTuan.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bai3_Dinh_Tuan.Controllers
{
    public class CategoryController : Controller
    {
        // GET: CategoryController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CategoryControllẻ/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoryControllẻ/Create
        public ActionResult Create([FromForm] Models.Category category)
        {
            if (ModelState.IsValid)
            {
                int maxId = SeedData.categories.Max(c => c.Id);
                category.Id = maxId + 1;

                SeedData.categories.Add(category);
                return RedirectToAction(nameof(Index));

                SeedData.categories.Add(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }



        // POST: CategoryControllẻ/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryControllẻ/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoryControllẻ/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([FromForm] Category category)
        {
            var existingCategory = SeedData.categories.FirstOrDefault(c => c.Id == category.Id);
            if (existingCategory == null)
            {
                return NotFound();
            }
            // Cập nhật thông tin của category tồn tại
            if (ModelState.IsValid)
            {
                existingCategory.Name = category.Name;
                existingCategory.Description = category.Description;
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }







        // GET: CategoryControllẻ/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryControllẻ/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var categoryToDelete = SeedData.categories.FirstOrDefault(c => c.Id == id);
            if (categoryToDelete == null)
            {
                return NotFound();
            }
            SeedData.categories.Remove(categoryToDelete);
            return RedirectToAction(nameof(Index));
        }
    }
}
