using ChocoStorageAPI.DBContexts;
using ChocoStorageAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChocoStorageAPI.Data
{
    public class ProductsDataRepository : IProductsDataRepository
    {
        private readonly Context _context;
        public ProductsDataRepository(Context context)
        {
            _context = context;
        }

        public Product? GetProduct(int productId)
        {
            return _context.Products.FirstOrDefault(p => p.ProductId == productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.OrderBy(x => x.ProductType).ToList(); ;
        }

        public void DeleteProduct(int productId)
        {
            var product = _context.Products.Find(productId);
            if (product != null)
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

        public void UpdateProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
        }

    }
}
