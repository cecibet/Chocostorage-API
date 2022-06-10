using System.ComponentModel.DataAnnotations;

namespace ChocoStorageAPI.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string? ChocolateType { get; set; }
        [Required]
        public int Weight { get; set; }
        public float Price { get; set; }
        public Product(string name)
        {
            Name = name.Trim();
        }
    }
}
