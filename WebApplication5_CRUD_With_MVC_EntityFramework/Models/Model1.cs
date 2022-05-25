using System;
using System.Data.Entity;
using System.Linq;

namespace WebApplication5_CRUD_With_MVC_EntityFramework.Models
{
    public class Model1 : DbContext
    {
        
        public Model1()
            : base("name=Model1")
        {
        }

       public virtual DbSet<Category> Categories { get; set; }
    }

}