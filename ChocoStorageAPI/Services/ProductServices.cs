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

        public ProductDto? GetProduct(int id)
        {
            var product = _productsDataRepository.GetProduct(id);
            return _mapper.Map<ProductDto?>(product);
        }

        public ProductDto AddProduct(ProductToCreateDto productToCreateDto)
        {
            var newProduct = _mapper.Map<Product>(productToCreateDto);

            return _mapper.Map<ProductDto>(newProduct);
        }

        public void DeleteProduct(int productId)
        {
            _productsDataRepository.DeleteProduct(productId);
            _productsDataRepository.SaveChange();
        }

    }



}
