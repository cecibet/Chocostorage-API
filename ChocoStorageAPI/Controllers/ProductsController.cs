using AutoMapper;
using ChocoStorageAPI.Data;
using ChocoStorageAPI.Models;
using ChocoStorageAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ChocoStorageAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductServices _productServices;
        public ProductsController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductDto>> GetProducts()
        {
            var products = _productServices.GetProducts();
            return Ok(products);
        }

        [HttpGet("{id}", Name = "GetProduct")]
        public IActionResult GetProduct(int id)

        {
            if (!_productServices.ProductExists(id))
                return NotFound();

            var product = _productServices.GetProduct(id);
            return Ok(product);
        }

        [HttpPost]
        public ActionResult<ProductDto> AddProduct(ProductToCreateDto product)
        {
            //agregar funcion productAlreadyExists en services (preguntar a nico como usar un tipo que admita 2)
            var productExists = _productServices.GetProducts().FirstOrDefault(x => x.ProductType == product.ProductType && x.ChocolateType == product.ChocolateType && x.Weight == product.Weight);
            var newProduct = _productServices.AddProduct(product);
            if (productExists is not null)
                return BadRequest("El producto ya existe");

            if (newProduct is null)
                return BadRequest("No se pudo crear el producto");

            return CreatedAtRoute(
                "GetProduct",
                new
                {
                    id = newProduct.ProductId
                },
                newProduct);
        }

        [HttpPut("{id}", Name = "UpdateProduct")]
        public ActionResult UpdateProduct(ProductToUpdateDto productToUpd, int id)
        {
            if (!_productServices.ProductExists(id))
                return NotFound();

            var productExists = _productServices.GetProducts().FirstOrDefault(x => x.ProductType == productToUpd.ProductType && x.ChocolateType == productToUpd.ChocolateType && x.Weight == productToUpd.Weight);
            if (productExists is not null)
                return BadRequest("Ya existe un producto con esas características");

            _productServices.UpdateProduct(productToUpd, id);
            return NoContent(); 
        }


        [HttpDelete("{id}", Name = "DeleteProduct")]
        public ActionResult DeleteProduct(int id)
        {
            if (!_productServices.ProductExists(id))
                return NotFound();

            _productServices.DeleteProduct(id);

            return NoContent();
        }
    }

}