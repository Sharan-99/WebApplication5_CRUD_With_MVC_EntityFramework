using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5_CRUD_With_MVC_EntityFramework.Models;
using System.ComponentModel.DataAnnotations;

namespace WebApplication5_CRUD_With_MVC_EntityFramework.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            var repository = new CategoriesRepository();
            var data = repository.GetAll();
            return View(data);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Category obj)
        {
            if(ModelState.IsValid)
            {
                var repository = new CategoriesRepository();
                bool saved = repository.Add(obj);
                if (saved)
                {
                    ViewBag.Message = "Category Saved";
                    return View(new Category());
                }
                else
                    ViewBag.Message = "Category Save failed";

            }

            
            return View(obj);
        }

        public ActionResult Edit(int id)
        {
            var repository = new CategoriesRepository();
            var data = repository.Find(id);

            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(int id,Category obj)
        {
            if(ModelState.IsValid)
            {
                var repository = new CategoriesRepository();
                bool updated = repository.Update(obj);
                if(updated)
                    return RedirectToAction("Index", "Categories");

                ViewBag.Message = "Update failed";
            }
            return View(obj);
        }

        public ActionResult Details(int id)
        {
            var repository = new CategoriesRepository();
            var category = repository.Find(id);
            return View(category);
        }

        public ActionResult Delete(int id)
        {
            var repository = new CategoriesRepository();
            var category = repository.Find(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            var repository = new CategoriesRepository();
            bool deleted = repository.Delete(id);
            if (deleted)
                RedirectToAction("Index", "Categories");

            TempData["Message"] = "Delete Category failed";
            return RedirectToAction("Delete", "Categories", new {id= id });
        }
    }
    
}