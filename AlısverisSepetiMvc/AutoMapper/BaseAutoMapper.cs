using AlısverisSepetiMvc.Models;
using AlısverisSepetiMvc.Models.Dto;
using AutoMapper;

namespace AlısverisSepetiMvc.AutoMapper
{
    public class BaseAutoMapper:Profile
    {
        public BaseAutoMapper()
        {
            CreateMap<Category, CategoryListDto>().ReverseMap();
            CreateMap<Product, ProductListDto>().ReverseMap();
        }
    }
}
