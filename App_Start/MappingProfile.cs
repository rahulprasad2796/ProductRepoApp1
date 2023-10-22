using AutoMapper;
using ProductRepoApp.Models;

namespace ProductRepoApp.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Product, ProductDTO>();
        }
    }
}