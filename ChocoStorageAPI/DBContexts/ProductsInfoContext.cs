using ChocoStorageAPI.Entities;
using ChocoStorageAPI.Enums;
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

            var products = new Product[4]
            {
                new Product()
                {
                    Id = 1,
                    ProductType = ProductTypes.HuevoDePascua,
                    ChocolateType = ChocolateTypes.Blanco,
                    Price = 300,
                },

                new Product()
                {
                    Id = 2,
                    ProductType = ProductTypes.HuevoDePascua,
                    ChocolateType = ChocolateTypes.Negro,
                    Weight = 70,
                    Price = 300,
                },

                new Product()
                {
                    Id = 3,
                    ProductType = ProductTypes.HuevoDePascua,
                    ChocolateType = ChocolateTypes.Negro,
                    Weight = 120,
                    Price = 500,
                },

                new Product()
                {
                    Id = 4,
                    ProductType = ProductTypes.ChocolateEnRama,
                    ChocolateType = ChocolateTypes.Blanco,
                    Weight = 70,
                    Price = 300,
                }
            };
            modelBuilder.Entity<Product>().HasData(products);

            base.OnModelCreating(modelBuilder);

        }
    }
}
