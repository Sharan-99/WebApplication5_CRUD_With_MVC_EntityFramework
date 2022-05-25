namespace WebApplication5_CRUD_With_MVC_EntityFramework.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication5_CRUD_With_MVC_EntityFramework.Models.Model1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication5_CRUD_With_MVC_EntityFramework.Models.Model1 context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Categories.AddOrUpdate(e => e.Name, new Models.Category { Name = "Electronics" },
                                                        new Models.Category { Name="Clothing"});
        }
    }
}
 