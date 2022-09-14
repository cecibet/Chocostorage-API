using AutoMapper;
using ChocoStorageAPI.Data;
using ChocoStorageAPI.Entities;
using ChocoStorageAPI.Models;

namespace ChocoStorageAPI.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IProductsDataRepository _productsDataRepository;
        private readonly IMapper _mapper;

        public ProductServices(IMapper mapper, IProductsDataRepository productsDataRepository)
        {
            _productsDataRepository = productsDataRepository;
            _mapper = mapper;
        }

        public IEnumerable<ProductDto> GetProducts()
        {
            var products = _productsDataRepository.GetProducts();
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public ProductDto GetProduct(int id)
        {
            var product = _productsDataRepository.GetProduct(id);
            return _mapper.Map<ProductDto>(product);
        }

        public ProductDto? AddProduct(ProductToCreateDto productToCreateDto)
        {
            var newProduct = _mapper.Map<Product>(productToCreateDto);
            _productsDataRepository.AddProduct(newProduct);
            if (_productsDataRepository.SaveChange())
            {
                return _mapper.Map<ProductDto>(newProduct);
            }
            return null;
        }

        public void UpdateProduct(ProductToUpdateDto productToUpd, int productId)
        {
            var product = _productsDataRepository.GetProduct(productId);
            _mapper.Map(productToUpd, product);
            _productsDataRepository.UpdateProduct(product);
            _productsDataRepository.SaveChange();
        }
        public void DeleteProduct(int id)
        {
            _productsDataRepository.DeleteProduct(id);
            _productsDataRepository.SaveChange();
        }
        public bool ProductExists(int id)
        {
            return _productsDataRepository.ProductExists(id);
        }
    }



}
