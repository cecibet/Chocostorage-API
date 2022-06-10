using ChocoStorageAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChocoStorageAPI.DBContexts

{
    public class ProductsInfoContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductsInfoContext(DbContextOptions<ProductsInfoContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>();
            var products = new Product[4]
            {
                new Product("Huevo de Pascua")
                {
                    Id = 1,
                    ChocolateType = "Blanco",
                    Weight = 70,
                    Price = 300,
                },

                new Product("Huevo de Pascua")
                {
                    Id = 2,
                    ChocolateType = "Negro",
                    Weight = 70,
                    Price = 300,
                },

                new Product("Huevo de Pascua")
                {
                    Id = 3,
                    ChocolateType = "Negro",
                    Weight = 120,
                    Price = 500,
                },

                new Product("Chocolate en rama")
                {
                    Id = 4,
                    ChocolateType = "Negro",
                    Weight = 70,
                    Price = 300,
                }
            };

            base.OnModelCreating(modelBuilder);

        }
    }
}
