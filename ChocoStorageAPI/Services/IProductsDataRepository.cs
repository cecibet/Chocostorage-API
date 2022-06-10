using ChocoStorageAPI.Entities;
namespace ChocoStorageAPI.Services

{
    public interface IProductsDataRepository
    {
        public IEnumerable<Product> GetProducts();
        public Product? GetProduct(int idProduct);
    }
}
