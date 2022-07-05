using AutoMapper;
using ChocoStorageAPI.Models;
using ChocoStorageAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChocoStorageAPI.Controllers
{
    [ApiController]
    [Route("api/sells")]
    public class SellsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISellServices _sellServices;

        public SellsController(ISellServices sellServices, IMapper mapper)
        {
            _sellServices = sellServices;
            _mapper = mapper;
        }


        [HttpGet]
        public ActionResult<IEnumerable<SellDto>> GetSells() //JsonResults implementa IActionResults
        {
            var sells = _sellServices.GetSells();
            return Ok(sells);
        }


        [HttpGet("{id}", Name = "GetSell")]
        public IActionResult GetSell(int id)

        {
            var sellOrder = _sellServices.GetSell(id);

            if (sellOrder is null)
                return NotFound();

            return Ok(sellOrder);
        }

        [HttpPost]
        public IActionResult AddSellOrder(SellToCreateDto newOrder)

        {

            ///agregar validacion de producto
            var createdSellOrder = _sellServices.AddNewSellOrder(newOrder);

            return CreatedAtRoute(//CreatedAtRoute es para que devuelva 201, el 200 de post.
                "GetSell", //El primer parámetro es el Name del endpoint que hace el Get
                new //El segundo los parametros que necesita ese endpoint
                {
                    id = createdSellOrder.SellId
                },
                createdSellOrder);

        }

        [HttpPut]
        public ActionResult UpdateSellOrder(SellToUpdateDto sellToUpdate, int sellId)
        {
            _sellServices.UpdateSell(sellToUpdate, sellId);

            return NoContent();
        }


        [HttpDelete("{id}")]
        public ActionResult DeleteSell(int id)
        {

            _sellServices.DeleteSell(id);

            return NoContent();
        }


    }
}

