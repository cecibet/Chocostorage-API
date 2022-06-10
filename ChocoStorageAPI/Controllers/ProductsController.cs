using AutoMapper;
using ChocoStorageAPI.Models;
using ChocoStorageAPI.Services;
using Microsoft.AspNetCore.Mvc;


namespace ChocoStorageAPI.Controllers
{

    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsDataRepository _productsDataRepository;
        private readonly IMapper _mapper;

        public ProductsController(IProductsDataRepository productsDataRepository, IMapper mapper)
        {
            _productsDataRepository = productsDataRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductDto>> GetProducts() //JsonResults implementa IActionResults
        {
            var products = _productsDataRepository.GetProducts();

            return Ok(_mapper.Map<IEnumerable<ProductDto>>(products));
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int idProduct)

        {
            var product = _productsDataRepository.GetProduct(idProduct);
            if (product == null)
                return NotFound();

            return Ok(_mapper.Map<ProductDto>(product));
        }


    }

}