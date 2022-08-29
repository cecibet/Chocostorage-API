using AutoMapper;
using ChocoStorageAPI.Data;
using ChocoStorageAPI.Entities;
using ChocoStorageAPI.Models;

namespace ChocoStorageAPI.Services
{
    public class SellServices : ISellServices
    {

        private readonly ISellsRepository _sellsRepository;
        private readonly IProductsDataRepository _productsDataRepository;
        private readonly IMapper _mapper;

        public SellServices(IMapper mapper, ISellsRepository sellsRepository, IProductsDataRepository productsDataRepository)
        {
            _sellsRepository = sellsRepository;
            _productsDataRepository = productsDataRepository;
            this._mapper = mapper;
        }

        public IEnumerable<SellDto> GetSells()
        {
            var sells = _sellsRepository.GetSells();
            return _mapper.Map<IEnumerable<SellDto>>(sells);
        }

        public SellDto? GetSell(int id)
        {
            var sellOrder = _sellsRepository.GetSell(id);
            return _mapper.Map<SellDto?>(sellOrder);
        }

        public SellDto AddNewSellOrder(SellToCreateDto newSellDto) // el metodo es para crear. se usa este servicio en el cntrolador dps, se instancia 
        {

            var newSell = _mapper.Map<SellOrder>(newSellDto);


            var unitPrice = _productsDataRepository.GetProducts()
                        .Where(p => p.ProductId == newSell.ProductId)
                        .Select(p => p.UnitPrice).First();

            var quantity = newSell.Quantity;

            newSell.TotalCost = unitPrice * quantity;
            if (StockIsEnough(newSell))
            {
                _sellsRepository.AddSellOrder(newSell);
                _sellsRepository.SaveChange();
            }

            return _mapper.Map<SellDto>(newSell);
        }

        public void UpdateSell(SellToUpdateDto sellToUpdateDto, int sellId)
        {
            var sellOrderToUpdate = _sellsRepository.GetSell(sellId);

            _mapper.Map(sellToUpdateDto, sellOrderToUpdate);

            var unitPrice = _productsDataRepository.GetProducts()
                        .Where(p => p.ProductId == sellOrderToUpdate.ProductId)
                        .Select(p => p.UnitPrice).First();

            var quantity = sellOrderToUpdate.Quantity;

            sellOrderToUpdate.TotalCost = unitPrice * quantity;
            if (StockIsEnough(sellOrderToUpdate))
            {
                _sellsRepository.UpdateSell(sellOrderToUpdate);
                _sellsRepository.SaveChange();
            }
        }

        public void DeleteSell(int sellId)
        {
            _sellsRepository.DeleteSell(sellId);
            _sellsRepository.SaveChange();
        }

        public bool StockIsEnough(SellOrder sellOrder) //se llama al crear venta 
        {
            var stock = _productsDataRepository.GetProducts()
                        .Where(p => p.ProductId == sellOrder.ProductId)
                        .Select(p => p.Stock).First();
            var quantity = sellOrder.Quantity;

            return stock >= quantity;
        }

        //public int UpdateStock(int quantity) // se llama aca tambien. de parametro mejor una unidad
        //{
        //    var stock = _productsDataRepository.GetProducts()
        //                .Where(p => p.ProductId == sellOrder.ProductId)
        //                .Select(p => p.Stock).First();
        //    var quantity = sellOrder.Quantity;
        //    var updatedStock = stock - quantity;
        //    stock = updatedStock;
        //    _productsDataRepository.SaveChange();
        //    return stock;
        //}

        ///declarar product exists aca

    }

}
