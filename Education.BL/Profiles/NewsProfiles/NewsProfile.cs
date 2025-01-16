using AutoMapper;
using Education.BL.DTOs.NewsDtos;
using Education.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.BL.Profiles.NewsProfiles
{
    public class NewsProfile : Profile
    {
        public NewsProfile()
        {
            CreateMap<NewsGetDetailDto, News>().ReverseMap();
            CreateMap<NewsGetDto, News>().ReverseMap();
            CreateMap<NewsPutDto, News>().ReverseMap();
            CreateMap<NewsPostDto, News>().ReverseMap();
        }
    }
}
