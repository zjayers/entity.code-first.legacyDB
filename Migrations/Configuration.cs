using System.Collections.ObjectModel;
using System.Data.Entity.Migrations;
using EntityFramework.CodeFirst.LegacyDb.Models;

namespace EntityFramework.CodeFirst.LegacyDb.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<PlutoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PlutoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Authors.AddOrUpdate(a => a.Name,
                new Author
                {
                    Name = "John Smith", Courses = new Collection<Course>
                    {
                        new Course {Name = "Course 1", Description = "Description"}
                    }
                });
        }
    }
}