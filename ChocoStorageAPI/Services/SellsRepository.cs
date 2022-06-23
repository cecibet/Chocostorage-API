using ChocoStorageAPI.DBContexts;
using ChocoStorageAPI.Entities;

namespace ChocoStorageAPI.Services
{
    public class SellsRepository : ISellsRepository
    {
        private readonly ProductsInfoContext _context;
        public SellsRepository(ProductsInfoContext context)
        {
            _context = context;
        }
        public SellOrder? GetSell(int sellId)
        {
            return _context.Sells.Where(s => s.SellId == sellId).FirstOrDefault(); ;
        }

        public IEnumerable<SellOrder> GetSells()
        {
            return _context.Sells.OrderBy(s => s.SellId).ToList(); ;
        }

        public bool SaveChange()
        {
            return (_context.SaveChanges() >= 0);
        }
        public Product? GetProduct(int productId)
        {
            return _context.Products.Where(p => p.ProductId == productId).FirstOrDefault(); ;
        }

        public void AddSellOrder(SellOrder sellOrder)
        {
            var product = GetProduct(sellOrder.ProductId);
            if (product != null)
                _context.Add(sellOrder);
        }
        public void DeleteSell(SellOrder sellOrder)
        {
            _context.Sells.Remove(sellOrder);
        }

        public bool ProductExists(int idProduct)
        {
            return _context.Products.Any(p => p.ProductId == idProduct);

        }

        public SellOrder? GetSellById(SellOrder sellOrder)
        {
            return _context.Sells
                .Where(p => p.ProductId == sellOrder.ProductId)
                .FirstOrDefault(); ;

        }

        public bool SellExists(int id)
        {
            return _context.Sells.Any(p => p.SellId == id);

        }
    }
}
