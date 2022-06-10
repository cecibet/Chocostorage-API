using ChocoStorageAPI.Enums;
using ChocoStorageAPI.Models;

namespace ChocoStorageAPI
{
    public class ProductsData
    {
        public List<ProductDto> Products { get; set; }

        public ProductsData()
        {
            Products = new List<ProductDto>()
            {
                new ProductDto()
                {
                    Id = 1,
                    ProductType = ProductTypes.HuevoDePascua,
                    ChocolateType = ChocolateTypes.Blanco,
                    Weight = 70,
                    Price = 300

                },

                new ProductDto()

                {
                    Id = 2,
                    ProductType = ProductTypes.HuevoDePascua,
                    ChocolateType = ChocolateTypes.Negro,
                    Weight = 70,
                    Price = 300,
                },

                new ProductDto()
                {
                    Id = 3,
                    ProductType = ProductTypes.HuevoDePascua,
                    ChocolateType = ChocolateTypes.Negro,
                    Weight = 120,
                    Price = 500,
                },

                new ProductDto()
                {
                    Id = 4,
                    ProductType = ProductTypes.ChocolateEnRama,
                    ChocolateType = ChocolateTypes.Negro,
                    Weight = 70,
                    Price = 300,
                }
            };
        }
    }
}