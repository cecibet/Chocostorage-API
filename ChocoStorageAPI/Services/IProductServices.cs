
using ChocoStorageAPI.Entities;
using ChocoStorageAPI.Models;

namespace ChocoStorageAPI.Services
{
    public interface IProductServices
    {
        IEnumerable<ProductDto> GetProducts();
        ProductDto GetProduct(int id);
        ProductDto? AddProduct(ProductToCreateDto productToCreateDto);
        public void UpdateProduct(ProductToUpdateDto productToUpd, int productId);
        public void DeleteProduct(int productId);
        public bool ProductExists(int productId);
    }
}
