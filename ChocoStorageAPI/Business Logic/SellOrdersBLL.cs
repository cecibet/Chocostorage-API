using ChocoStorageAPI.Entities;
using ChocoStorageAPI.Services;

namespace ChocoStorageAPI.Business_Logic
{
    public class SellsBLLContext
    {

        private readonly ISellsRepository _sellsRepository;
        private readonly IProductsDataRepository _productsDataRepository;

        public SellsBLLContext(ISellsRepository sellsRepository, IProductsDataRepository productsDataRepository)
        {
            _sellsRepository = sellsRepository;
            _productsDataRepository = productsDataRepository;
        }

        public float GetTotalCost(SellOrder sellOrder)
        {

            var unitPrice = _productsDataRepository.GetProducts()
                        .Where(p => p.ProductId == sellOrder.ProductId)
                        .Select(p => p.UnitPrice).First();
            var quantity = sellOrder.Quantity;

            var totalCost = unitPrice * quantity;

            sellOrder.TotalCost = totalCost;

            return sellOrder.TotalCost;
        }

        public int UpdateStock(SellOrder sellOrder, Product product)
        {
            var quantity = sellOrder.Quantity;
            var updatedStock = product.Stock - quantity;

            product.Stock = updatedStock;
            return product.Stock;
        }
    }

}
