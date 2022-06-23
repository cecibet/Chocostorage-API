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
        private readonly ISellsRepository _sellsRepository;
        private readonly IMapper _mapper;
        public SellsController(ISellsRepository sellsRepository, IMapper mapper)
        {
            _sellsRepository = sellsRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<SellDto>> GetSells() //JsonResults implementa IActionResults
        {
            var sells = _sellsRepository.GetSells();
            return Ok(_mapper.Map<IEnumerable<SellDto>>(sells));
        }

        [HttpGet("{id}", Name = "GetSell")]
        public IActionResult GetSell(int id)

        {
            if (!_sellsRepository.SellExists(id))
                return NotFound();

            var sellOrder = _sellsRepository.GetSell(id);

            return Ok(_mapper.Map<SellDto>(sellOrder));
        }

        [HttpPost]
        public IActionResult AddSellOrder(SellToCreateDto sellOrder)

        {
            if (!_sellsRepository.ProductExists(sellOrder.ProductId))
            {
                return NotFound();
            }
            var newSell = _mapper.Map<Entities.SellOrder>(sellOrder);

            _sellsRepository.AddSellOrder(newSell);
            _sellsRepository.SaveChange();

            var sellOrderToReturn = _mapper.Map<SellDto>(newSell);

            return CreatedAtRoute(//CreatedAtRoute es para que devuelva 201, el 200 de post.
                "GetSell", //El primer parámetro es el Name del endpoint que hace el Get
                new //El segundo los parametros que necesita ese endpoint
                {
                    id = sellOrderToReturn.SellId
                },
                sellOrderToReturn);

        }

        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id, SellToUpdateDto sell)
        {
            if (!_sellsRepository.SellExists(id))
                return NotFound();

            var sellInDB = _sellsRepository.GetSell(id);

            _mapper.Map(sell, sellInDB);

            _sellsRepository.SaveChange();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteSell(int id)
        {
            if (!_sellsRepository.SellExists(id))
                return NotFound();

            var sellToDelete = _sellsRepository.GetSell(id);

            _sellsRepository.DeleteSell(sellToDelete);
            _sellsRepository.SaveChange();

            return NoContent();
        }


    }
}

