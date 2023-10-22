namespace ProductRepoApp.Migrations
{
    using ProductRepoApp.Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductRepoApp.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProductRepoApp.ProductContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            List<Product> products = new List<Product>
            {
                new Product { Name = "ParleG", Price = 20},
                new Product { Name = "Tiger", Price = 10},
                new Product { Name = "Mentos", Price = 1},
                new Product { Name = "Hide & Seek", Price = 30},
                new Product { Name = "Bourbon", Price = 5}
            };

            products.ForEach(s => context.Products.AddOrUpdate(n => n.Name, s));
            context.SaveChanges();
        }
    }
}
