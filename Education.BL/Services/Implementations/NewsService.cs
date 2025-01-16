using AutoMapper;
using Education.BL.DTOs.NewsDtos;
using Education.BL.Services.Abstractions;
using Education.Core.Models;
using Education.DAL.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.BL.Services.Implementations
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _newsRepo;
        private readonly IMapper _mapper;

        public NewsService(INewsRepository newsRepo, IMapper mapper)
        {
            _newsRepo = newsRepo;
            _mapper = mapper;
        }

        public async Task<bool> CreateNewsAsync(NewsPostDto newsPostDto)
        {
            News news = _mapper.Map<News>(newsPostDto);
            news.CreatedAt = DateTime.Now;
            await _newsRepo.CreateAsync(news);
            int rows = await _newsRepo.SaveChangesAsync();
            if (rows == 0)
            {
                throw new Exception("Something went wrong");
            }
            return true;

        }

        public async Task<bool> DeleteNewsAsync(int id)
        {
            var entity = await _newsRepo.GetByIdAsync(id, false);
            if (entity == null) { throw new Exception("Something went wrong"); }
            _newsRepo.Delete(entity);
            int rows = await _newsRepo.SaveChangesAsync();
            if (rows == 0) { throw new Exception("Something went wrong"); }
            return true;
        }

        public async Task<ICollection<NewsGetDto>> GetAllNewsAsync()
        {
            var entity = await _newsRepo.GetAllAsync();
            if(entity is null)
            {
                throw new Exception("Something went wrong");
            }
            ICollection<NewsGetDto> newsGets = _mapper.Map<ICollection<NewsGetDto>>(entity);
            return newsGets;

        }

        public async Task<NewsGetDetailDto> GetByIdNewsAsync(int id)
        {
            var entity = await _newsRepo.GetByIdAsync(id, true, "News");
            if (entity is null)
            {
                throw new Exception("Something went wrong");
            }
            NewsGetDetailDto news = _mapper.Map<NewsGetDetailDto>(entity);
            return news;
        }

        public async Task<bool> UpdateNewsAsync( int id, NewsPutDto newsPutDto)
        {
            var entity = await _newsRepo.GetByIdAsync(id, false) ?? throw new Exception("Something went wrong");
            News news = _mapper.Map<News>(newsPutDto);
            _newsRepo.Update(news);
            int rows = await _newsRepo.SaveChangesAsync();
            if (rows == 0)
            {
                throw new Exception("Something went wrong");
            }
            return true;
        }
    }
}
