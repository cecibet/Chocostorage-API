using ChocoStorageAPI.Enums;
using ChocoStorageAPI.Models;

namespace ChocoStorageAPI
{
    public class ProductsData
    {
        public List<ProductDto> Products { get; set; }
        public List<SellDto> Sells { get; set; }

        public ProductsData()
        {
            Products = new List<ProductDto>()
            {
                new ProductDto()
                {
                    ProductId = 1,
                    ProductType = ProductTypes.HuevoDePascua,
                    ChocolateType = ChocolateTypes.Blanco,
                    Weight = 70,
                    UnitPrice = 300,
                    Stock = 50

                },

                new ProductDto()

                {
                    ProductId = 2,
                    ProductType = ProductTypes.HuevoDePascua,
                    ChocolateType = ChocolateTypes.Negro,
                    Weight = 70,
                    UnitPrice = 300,
                    Stock = 50
                },

                new ProductDto()
                {
                    ProductId = 3,
                    ProductType = ProductTypes.HuevoDePascua,
                    ChocolateType = ChocolateTypes.Negro,
                    Weight = 120,
                    UnitPrice = 500,
                    Stock = 20
                },

                new ProductDto()
                {
                    ProductId = 4,
                    ProductType = ProductTypes.ChocolateEnRama,
                    ChocolateType = ChocolateTypes.Negro,
                    Weight = 70,
                    UnitPrice = 300,
                    Stock = 4
                }
            };

            Sells = new List<SellDto>()
            {
                new SellDto()
                {
                   SellId = 1,
                    Date = DateTime.Now,
                    ProductId = 3,
                    Quantity = 5,
                    ShippingType = ShippingTypes.Retiro

                },

                new SellDto()

                {
                    SellId = 2,
                    Date = DateTime.Now,
                    ProductId = 4,
                    Quantity = 5,
                    ShippingType = ShippingTypes.ADomicilio
                }


            };
        }
    }
}