using AutoMapper;
using Education.BL.DTOs.CategoryDtos;
using Education.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.BL.Profiles.CategoryProfiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryGetDetailDto, Category>().ReverseMap();
            CreateMap<CategoryGetDto, Category>().ReverseMap();
            CreateMap<CategoryPutDto, Category>().ReverseMap();
            CreateMap<CategoryPostDto, Category>().ReverseMap();
        }
    }
}
