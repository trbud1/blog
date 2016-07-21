namespace Blog.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Blog.Models.BlogDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Blog.Models.BlogDBContext context)
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

            //ID,Title,Message,TimeToRead,Rating
            context.Blogs.AddOrUpdate(i => i.ID,
                new Post
                {
                    ID= 1,
                    Title= "Another set of woe",
                    Message= "dsfsdfd",
                    TimeToRead= 1,
                    Rating= 1.1f,
                    PublishedDate = DateTime.Parse("1999-1-11")


                },
                new Post
                {
                    ID= 2,
                    Title= "woe",
                    Message= "dsfsdssddfd",
                    TimeToRead= 3,
                    Rating= 1.1f,
                    PublishedDate = DateTime.Parse("2001-1-11")

                },
                new Post
                {
                    ID= 3,
                    Title= "Anot",
                    Message= "eeeeeee",
                    TimeToRead= 55,
                    Rating= 4.1f,
                    PublishedDate = DateTime.Parse("2015-1-11")

                }


           );
        }
    }
}
