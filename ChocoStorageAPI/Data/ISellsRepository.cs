using ChocoStorageAPI.Entities;

namespace ChocoStorageAPI.Data
{
    public interface ISellsRepository
    {
        public IEnumerable<SellOrder> GetSells();
        public SellOrder? GetSell(int idSell);
        public Product? GetProduct(int idProduct);
        public void AddSellOrder(SellOrder sellOrder);
        public void DeleteSell(int sellId);
        public bool SaveChange();
        public void UpdateSell(SellOrder sellOrder);



    }
}
