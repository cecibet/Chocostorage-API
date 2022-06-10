using ChocoStorageAPI.Enums;

namespace ChocoStorageAPI.Models
{
    public class ProductDto
    {
        public int Id { get; set; }
        public ProductTypes ProductType { get; set; } = ProductTypes.HuevoDePascua;
        public ChocolateTypes ChocolateType { get; set; } = ChocolateTypes.Blanco;
        public int Weight { get; set; }
        public int Price { get; set; }

    }
}
