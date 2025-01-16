using Education.BL.DTOs.NewsDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.BL.Services.Abstractions
{
    public interface INewsService
    {
        Task<ICollection<NewsGetDto>> GetAllNewsAsync();
        Task<NewsGetDetailDto> GetByIdNewsAsync(int id);
        Task<bool> CreateNewsAsync(NewsPostDto newsPostDto);
        Task<bool> DeleteNewsAsync(int id);
        Task<bool> UpdateNewsAsync( int id,NewsPutDto newsPutDto);
    }
}
