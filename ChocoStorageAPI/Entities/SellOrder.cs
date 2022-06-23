using ChocoStorageAPI.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ChocoStorageAPI.Entities
{
    public class SellOrder
    {
        [Key]
        public int SellId { get; set; }
        public DateTime Date { get; set; }

        [Required]
        public int Quantity { get; set; }
        public float TotalCost { get; set; }

        public ShippingTypes? ShippingType { get; set; }

        [ForeignKey("ProductId")]
        public Product? ProductInOrder { get; set; }

        public int ProductId { get; set; }
    }
}
