using AutoMapper;
namespace ChocoStorageAPI.AutoMapperProfiles
{
    public class SellProfile : Profile
    {
        public SellProfile()
        {
            CreateMap<Entities.SellOrder, Models.SellDto>();
            CreateMap<Models.SellToCreateDto, Entities.SellOrder>();
            CreateMap<Models.SellToCreateDto, Entities.Product>();
            CreateMap<Models.SellToUpdateDto, Entities.SellOrder>();
            CreateMap<Entities.SellOrder, Models.SellToUpdateDto>();
        }
    }
}
