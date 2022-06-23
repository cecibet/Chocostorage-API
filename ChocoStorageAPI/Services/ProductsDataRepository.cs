using ChocoStorageAPI.DBContexts;
using ChocoStorageAPI.Entities;

namespace ChocoStorageAPI.Services
{
    public class ProductsDataRepository : IProductsDataRepository
    {
        private readonly ProductsInfoContext _context;
        public ProductsDataRepository(ProductsInfoContext context)
        {
            _context = context;
        }

        public Product? GetProduct(int productId)
        {
            return _context.Products.Where(p => p.ProductId == productId).FirstOrDefault(); ;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.OrderBy(x => x.ProductType).ToList(); ;
        }


        public void DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
        }

        public void AddProduct(Product product)
        {
            _context.Add(product);
        }

        public bool SaveChange()
        {
            return (_context.SaveChanges() >= 0);
        }

        public bool ProductExists(int idProduct)
        {
            return _context.Products.Any(p => p.ProductId == idProduct);

        }

    }
}
