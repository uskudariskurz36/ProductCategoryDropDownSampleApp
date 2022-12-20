using AutoMapper;
using ProductCategoryDropDownSampleApp.Entities;
using ProductCategoryDropDownSampleApp.Models;

namespace ProductCategoryDropDownSampleApp
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ProductCreateViewModel, Product>().ReverseMap();
        }
    }
}
