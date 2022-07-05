using ChocoStorageAPI.Entities;
namespace ChocoStorageAPI.Data

{
    public interface IProductsDataRepository
    {
        public IEnumerable<Product> GetProducts();
        public Product? GetProduct(int idProduct);
        public void AddProduct(Product product);
        public void DeleteProduct(int productId);
        public void UpdateProduct(Product product);
        public bool SaveChange();
    }
}
