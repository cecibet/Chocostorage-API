using ChocoStorageAPI.Enums;
using System.Text.Json.Serialization;

namespace ChocoStorageAPI.Models
{
    public class ProductDto
    {
        public int Id { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ProductTypes ProductType { get; set; } = ProductTypes.HuevoDePascua;
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ChocolateTypes ChocolateType { get; set; } = ChocolateTypes.Blanco;
        public int Weight { get; set; }
        public int Price { get; set; }

    }
}
