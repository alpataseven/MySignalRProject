using AutoMapper;
using DtoLayer.CategoryDto;
using EntityLayer.Entities;

namespace MyProjectAPI.Mapping
{
    public class CategoryMapping:Profile
    {
        public CategoryMapping()
        {
                CreateMap<Category, ResultCategoryDto>().ReverseMap();
                CreateMap<Category, CreateCategoryDto>().ReverseMap();
                CreateMap<Category, GetCategoryDto>().ReverseMap();
                CreateMap<Category, UpdateCategoryDto>().ReverseMap();
        }
    }
}
