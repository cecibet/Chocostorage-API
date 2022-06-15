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

            var products = new Product[17]
            {
                new Product()
                {
                    Id = 1,
                    ProductType = ProductTypes.HuevoDePascua,
                    ChocolateType = ChocolateTypes.Blanco,
                    Weight = 70,
                    Price = 300,
                    Stock = 50
                },

                new Product()
                {
                    Id = 2,
                    ProductType = ProductTypes.HuevoDePascua,
                    ChocolateType = ChocolateTypes.Blanco,
                    Weight = 110,
                    Price = 500,
                    Stock = 20
                },

                new Product()
                {
                    Id = 3,
                    ProductType = ProductTypes.HuevoDePascua,
                    ChocolateType = ChocolateTypes.Negro,
                    Weight = 70,
                    Price = 300,
                    Stock = 20
                },

                new Product()
                {
                    Id = 4,
                    ProductType = ProductTypes.HuevoDePascua,
                    ChocolateType = ChocolateTypes.Negro,
                    Weight = 110,
                    Price = 500,
                    Stock = 20
                },

                new Product()
                {
                    Id = 5,
                    ProductType = ProductTypes.ChocolateEnBarra,
                    ChocolateType = ChocolateTypes.Amargo,
                    Weight = 120,
                    Price = 400,
                    Stock = 4
                },

                new Product()
                {
                    Id = 6,
                    ProductType = ProductTypes.ChocolateEnBarra,
                    ChocolateType = ChocolateTypes.Amargo,
                    Weight = 180,
                    Price = 600,
                    Stock = 20
                },
                new Product()
                {
                    Id = 7,
                    ProductType = ProductTypes.ChocolateEnBarra,
                    ChocolateType = ChocolateTypes.Amargo,
                    Weight = 300,
                    Price = 750,
                    Stock = 20
                },
                new Product()
                {
                    Id = 8,
                    ProductType = ProductTypes.ChocolateEnBarra,
                    ChocolateType = ChocolateTypes.Mani,
                    Weight = 120,
                    Price = 400,
                    Stock = 4
                },

                new Product()
                {
                    Id = 9,
                    ProductType = ProductTypes.ChocolateEnBarra,
                    ChocolateType = ChocolateTypes.Mani,
                    Weight = 180,
                    Price = 600,
                    Stock = 20
                },
                new Product()
                {
                    Id = 10,
                    ProductType = ProductTypes.ChocolateEnBarra,
                    ChocolateType = ChocolateTypes.Mani,
                    Weight = 300,
                    Price = 750,
                    Stock = 20
                },

                new Product()
                {
                    Id = 11,
                    ProductType = ProductTypes.ChocolateEnBarra,
                    ChocolateType = ChocolateTypes.Leche,
                    Weight = 120,
                    Price = 400,
                    Stock = 4
                },

                new Product()
                {
                    Id = 12,
                    ProductType = ProductTypes.ChocolateEnBarra,
                    ChocolateType = ChocolateTypes.Leche,
                    Weight = 180,
                    Price = 600,
                    Stock = 20
                },
                new Product()
                {
                    Id = 13,
                    ProductType = ProductTypes.ChocolateEnBarra,
                    ChocolateType = ChocolateTypes.Leche,
                    Weight = 300,
                    Price = 750,
                    Stock = 20
                },

                new Product()
                {
                    Id = 14,
                    ProductType = ProductTypes.ChocolateEnRama,
                    ChocolateType = ChocolateTypes.Blanco,
                    Weight = 70,
                    Price = 350,
                    Stock = 10
                },

                new Product()
                {
                    Id = 15,
                    ProductType = ProductTypes.ChocolateEnRama,
                    ChocolateType = ChocolateTypes.Blanco,
                    Weight = 160,
                    Price = 500,
                    Stock = 20
                },

                new Product()
                {
                    Id = 16,
                    ProductType = ProductTypes.ChocolateEnRama,
                    ChocolateType = ChocolateTypes.Negro,
                    Weight = 70,
                    Price = 350,
                    Stock = 20
                },

                new Product()
                {
                    Id = 17,
                    ProductType = ProductTypes.ChocolateEnRama,
                    ChocolateType = ChocolateTypes.Negro,
                    Weight = 160,
                    Price = 500,
                    Stock = 2
                },
            };
            modelBuilder.Entity<Product>().HasData(products);

            base.OnModelCreating(modelBuilder);

        }
    }
}
