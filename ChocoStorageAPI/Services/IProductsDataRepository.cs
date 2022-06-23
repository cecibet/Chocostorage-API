using ChocoStorageAPI.Entities;
namespace ChocoStorageAPI.Services

{
    public interface IProductsDataRepository
    {
        public IEnumerable<Product> GetProducts();
        public Product? GetProduct(int idProduct);
        public void AddProduct(Product product);
        public bool SaveChange();
        public bool ProductExists(int id);
        void DeleteProduct(Product product);

    }
}
