using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5_CRUD_With_MVC_EntityFramework.Models
{
    public class CategoriesRepository
    {
        private readonly Model1 context;
        public CategoriesRepository()
        {
            context = new Model1();
        }

        public List<Category> GetAll()
        {
            var query = from obj in context.Categories
                        select obj;
            return query.ToList();
        }

        public bool Add(Category obj)
        {
            context.Categories.Add(obj);
            int rows = context.SaveChanges();
            return rows == 1;
        }

        public Category Find(int id)
        {
            return context.Categories.Find(id);
        }

        public bool Update(Category obj)
        {
            var category = context.Categories.Find(obj.Id);
            category.Name = obj.Name;
            int rows = context.SaveChanges();
            return rows == 1;

        }
        public bool Delete(int id)
        {
            var category = context.Categories.Find(id);
            context.Categories.Remove(category);
            int rows = context.SaveChanges();
            return rows == 1;
        }
    }
}