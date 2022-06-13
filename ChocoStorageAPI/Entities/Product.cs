using ChocoStorageAPI.Enums;
using System.ComponentModel.DataAnnotations;

namespace ChocoStorageAPI.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public ProductTypes ProductType { get; set; }
        [Required]
        [MaxLength(50)]
        public ChocolateTypes ChocolateType { get; set; }
        [Required]
        public int Weight { get; set; }
        public float Price { get; set; }

    }
}
