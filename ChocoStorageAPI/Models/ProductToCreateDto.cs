using ChocoStorageAPI.Enums;
using System.Text.Json.Serialization;

namespace ChocoStorageAPI.Models
{
    public class ProductToCreateDto
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ProductTypes ProductType { get; set; } = ProductTypes.HuevoDePascua;
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ChocolateTypes ChocolateType { get; set; } = ChocolateTypes.Blanco;
        public int Weight { get; set; }
        public int UnitPrice { get; set; }
        public int Stock { get; set; }
    }
}
