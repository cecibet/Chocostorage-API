using ChocoStorageAPI.Entities;

namespace ChocoStorageAPI.Services
{
    public interface ISellsRepository
    {
        public IEnumerable<SellOrder> GetSells();
        public SellOrder? GetSell(int idSell);
        public void AddSellOrder(SellOrder sellOrder);
        void DeleteSell(SellOrder sellOrder);
        public bool SaveChange();
        public bool ProductExists(int idProduct);
        public Product? GetProduct(int idProduct);
        public SellOrder? GetSellById(SellOrder sellOrder);
        public bool SellExists(int id);
    }
}
