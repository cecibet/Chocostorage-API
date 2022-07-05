
using ChocoStorageAPI.Models;

namespace ChocoStorageAPI.Services
{
    public interface IProductServices
    {
        IEnumerable<ProductDto> GetProducts();
        ProductDto? GetProduct(int id);
        ProductDto AddProduct(ProductToCreateDto productToCreateDto);
        public void DeleteProduct(int productId);
    }
}
