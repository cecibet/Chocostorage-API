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

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.OrderBy(x => x.Name).ToList(); ;
        }

        public bool SaveChange()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
