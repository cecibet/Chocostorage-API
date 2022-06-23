using ChocoStorageAPI.Enums;
using System.ComponentModel.DataAnnotations;

namespace ChocoStorageAPI.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(50)]
        public ProductTypes ProductType { get; set; }
        [Required]
        [MaxLength(50)]
        public ChocolateTypes ChocolateType { get; set; }
        [Required]
        public int Weight { get; set; }
        [Required]
        public float UnitPrice { get; set; }
        [Required]
        public int Stock { get; set; }
        public List<SellOrder>? SellOrders { get; set; }
    }
}
