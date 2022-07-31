using ChocoStorageAPI.Entities;
using ChocoStorageAPI.Enums;
using Microsoft.EntityFrameworkCore;


namespace ChocoStorageAPI.DBContexts

{
    public class ProductsInfoContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<SellOrder> Sells { get; set; }
        public DbSet<User> Users { get; set; }

        public ProductsInfoContext(DbContextOptions<ProductsInfoContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var products = new Product[17] {

                new Product()
                {
                    ProductId = 1,
                    ProductType = ProductTypes.HuevoDePascua,
                    ChocolateType = ChocolateTypes.Blanco,
                    Weight = 70,
                    UnitPrice = 300,
                    Stock = 50
                },

                new Product()
                {
                    ProductId = 2,
                    ProductType = ProductTypes.HuevoDePascua,
                    ChocolateType = ChocolateTypes.Blanco,
                    Weight = 110,
                    UnitPrice = 500,
                    Stock = 20
                },

                new Product()
                {
                    ProductId = 3,
                    ProductType = ProductTypes.HuevoDePascua,
                    ChocolateType = ChocolateTypes.Negro,
                    Weight = 70,
                    UnitPrice = 300,
                    Stock = 20,
                },

                new Product()
                {
                    ProductId = 4,
                    ProductType = ProductTypes.HuevoDePascua,
                    ChocolateType = ChocolateTypes.Negro,
                    Weight = 110,
                    UnitPrice = 500,
                    Stock = 20
                },

                new Product()
                {
                    ProductId = 5,
                    ProductType = ProductTypes.ChocolateEnBarra,
                    ChocolateType = ChocolateTypes.Amargo,
                    Weight = 120,
                    UnitPrice = 400,
                    Stock = 4
                },

                new Product()
                {
                    ProductId = 6,
                    ProductType = ProductTypes.ChocolateEnBarra,
                    ChocolateType = ChocolateTypes.Amargo,
                    Weight = 180,
                    UnitPrice = 600,
                    Stock = 20
                },
                new Product()
                {
                    ProductId = 7,
                    ProductType = ProductTypes.ChocolateEnBarra,
                    ChocolateType = ChocolateTypes.Amargo,
                    Weight = 300,
                    UnitPrice = 750,
                    Stock = 20
                },
                new Product()
                {
                    ProductId = 8,
                    ProductType = ProductTypes.ChocolateEnBarra,
                    ChocolateType = ChocolateTypes.Mani,
                    Weight = 120,
                    UnitPrice = 400,
                    Stock = 4
                },

                new Product()
                {
                    ProductId = 9,
                    ProductType = ProductTypes.ChocolateEnBarra,
                    ChocolateType = ChocolateTypes.Mani,
                    Weight = 180,
                    UnitPrice = 600,
                    Stock = 20
                },
                new Product()
                {
                    ProductId = 10,
                    ProductType = ProductTypes.ChocolateEnBarra,
                    ChocolateType = ChocolateTypes.Mani,
                    Weight = 300,
                    UnitPrice = 750,
                    Stock = 20
                },

                new Product()
                {
                    ProductId = 11,
                    ProductType = ProductTypes.ChocolateEnBarra,
                    ChocolateType = ChocolateTypes.Leche,
                    Weight = 120,
                    UnitPrice = 400,
                    Stock = 4
                },

                new Product()
                {
                    ProductId = 12,
                    ProductType = ProductTypes.ChocolateEnBarra,
                    ChocolateType = ChocolateTypes.Leche,
                    Weight = 180,
                    UnitPrice = 600,
                    Stock = 20
                },
                new Product()
                {
                    ProductId = 13,
                    ProductType = ProductTypes.ChocolateEnBarra,
                    ChocolateType = ChocolateTypes.Leche,
                    Weight = 300,
                    UnitPrice = 750,
                    Stock = 20
                },

                new Product()
                {
                    ProductId = 14,
                    ProductType = ProductTypes.ChocolateEnRama,
                    ChocolateType = ChocolateTypes.Blanco,
                    Weight = 70,
                    UnitPrice = 350,
                    Stock = 10
                },

                new Product()
                {
                    ProductId = 15,
                    ProductType = ProductTypes.ChocolateEnRama,
                    ChocolateType = ChocolateTypes.Blanco,
                    Weight = 160,
                    UnitPrice = 500,
                    Stock = 20
                },

                new Product()
                {
                    ProductId = 16,
                    ProductType = ProductTypes.ChocolateEnRama,
                    ChocolateType = ChocolateTypes.Negro,
                    Weight = 70,
                    UnitPrice = 350,
                    Stock = 20
                },

                new Product()
                {
                    ProductId = 17,
                    ProductType = ProductTypes.ChocolateEnRama,
                    ChocolateType = ChocolateTypes.Negro,
                    Weight = 160,
                    UnitPrice = 500,
                    Stock = 2
                } };

            modelBuilder.Entity<Product>().HasData(products);


            //modelBuilder.Entity<SellOrder>()
            //    .HasOne(p => p.ProductInOrder)
            //    .WithMany(s => s.SellOrders);

            var sells = new SellOrder[2] {
                new SellOrder()
                {
                    SellId = 1,
                    Date = DateTime.Now,
                    ProductId = products[1].ProductId,
                    Quantity = 5,
                    TotalCost = 2500,
                    ShippingType = ShippingTypes.Retiro

                },

                new SellOrder()
                {
                    SellId = 2,
                    Date = DateTime.Now,
                    ProductId = products[2].ProductId,
                    Quantity = 5,
                    TotalCost = 3000,
                    ShippingType = ShippingTypes.ADomicilio

                }

            };


            modelBuilder.Entity<SellOrder>().HasData(sells);

            var users = new User[3] {
                new User()
                {
                    Id = 1,
                    Name = "Cecilia",
                    SurName = "Bettiol",
                    Password = "ceci123",
                    UserName = "cecibet",
                    Role = UserTypes.supervisor

                },
                 new User()
                {
                    Id = 2,
                    Name = "Fabrizio",
                    SurName = "De Lisa",
                    Password = "fabra456",
                    UserName = "fadelis",
                    Role = UserTypes.employee

                },
                  new User()
                {
                    Id = 3,
                    Name = "Lucas",
                    SurName = "De Lorenzi",
                    Password = "lucas789",
                    UserName = "lukedelo",
                    Role = UserTypes.employee

                }

            };

            modelBuilder.Entity<User>().HasData(users);

            base.OnModelCreating(modelBuilder);

        }
    }
}
