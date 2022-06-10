namespace ChocoStorageAPI.Models
{
    public class PurchasetDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<ProductDto>? Items { get; set; }

        public int Quantity { get; set; }
        public float TotalCost { get; set; }
    }
}
