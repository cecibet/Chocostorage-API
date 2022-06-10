using AutoMapper;
namespace ChocoStorageAPI.AutoMapperProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Entities.Product, Models.ProductDto>();
        }
    }
}


