using ChocoStorageAPI.DBContexts;
using ChocoStorageAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChocoStorageAPI.Data
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
            return _context.Sells.OrderBy(s => s.SellId).ToList();
        }

        public bool SaveChange()
        {
            return (_context.SaveChanges() >= 0);
        }
        public Product? GetProduct(int productId)
        {
            return _context.Products.FirstOrDefault(p => p.ProductId == productId);
        }

        public void AddSellOrder(SellOrder sellOrder)
        {
            var product = GetProduct(sellOrder.ProductId);

            if (product != null)
                _context.Add(sellOrder);

        }

        public void DeleteSell(int sellId)
        {
            var sell = _context.Sells.Find(sellId);
            if (sell != null)
                _context.Sells.Remove(sell);
        }


        public bool SellExists(int id)
        {
            return _context.Sells.Any(p => p.SellId == id);

        }
        public void UpdateSell(SellOrder sellOrder)
        {
            _context.Entry(sellOrder).State = EntityState.Modified;
        }
    }
}
