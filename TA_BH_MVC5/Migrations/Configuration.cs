using TA_BH_MVC5.Models;

namespace TA_BH_MVC5.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TA_BH_MVC5.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TA_BH_MVC5.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Commands.AddOrUpdate(
              p => p.Code,
              new Command { Code = "HOME", Description = "Home Page", Controller = "Home", Action = "Index" },
              new Command { Code = "AC", Description = "Alpha Controller", Controller = "Alpha", Action = "Index" },
              new Command { Code = "BC", Description = "Beta Controller", Controller = "Beta", Action = "Index" },
              new Command { Code = "DC", Description = "Delta Controller", Controller = "Delta", Action = "Index" }

            );
        }
    }
}
