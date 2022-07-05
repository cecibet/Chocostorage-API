using ChocoStorageAPI.Models;

namespace ChocoStorageAPI.Services
{
    public interface ISellServices
    {
        SellDto AddNewSellOrder(SellToCreateDto newSellDto);

        public SellDto? GetSell(int id);
        IEnumerable<SellDto> GetSells();
        public void DeleteSell(int sellId);

        public SellDto UpdateSell(SellToUpdateDto sellToUpdateDto, int sellId);

    }
}
