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

        [HttpGet("{id}", Name = "GetProduct")]
        public IActionResult GetProduct(int id)

        {
            var product = _productsDataRepository.GetProduct(id);
            if (product == null)
                return NotFound();

            return Ok(_mapper.Map<ProductDto>(product));
        }

        [HttpPost]
        public ActionResult<ProductDto> AddProduct(ProductToCreateDto product)
        {
            var newProduct = _mapper.Map<Entities.Product>(product);

            _productsDataRepository.AddProduct(newProduct);

            _productsDataRepository.SaveChange();

            var productToReturn = _mapper.Map<ProductDto>(newProduct);

            return CreatedAtRoute(//CreatedAtRoute es para q devuelva 201, el 200 de post.
                "GetPuntoDeInteres", //El primer parámetro es el Name del endpoint que hace el Get
                new //El segundo los parametros q necesita ese endpoint
                {
                    id = productToReturn.ProductId
                },
                productToReturn);//El tercero es el objeto creado. 
        }

        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id, ProductToUpdateDto product)
        {
            if (!_productsDataRepository.ProductExists(id))
                return NotFound();

            var productInDB = _productsDataRepository.GetProduct(id);

            _mapper.Map(product, productInDB);

            _productsDataRepository.SaveChange();

            return NoContent();
        }


        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            if (!_productsDataRepository.ProductExists(id))
                return NotFound();

            var productToDelete = _productsDataRepository.GetProduct(id);

            _productsDataRepository.DeleteProduct(productToDelete);
            _productsDataRepository.SaveChange();

            return NoContent();
        }

    }

}