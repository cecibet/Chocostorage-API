namespace ChocoStorageAPI.Models
{
    public class PurchasetDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public ICollection<ProductDto> SellProducts { get; set; } = new List<ProductDto>();

        public int Quantity { get; set; }
        public float TotalCost { get; set; }
    }
}
