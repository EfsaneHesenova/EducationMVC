using Education.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.BL.DTOs.NewsDtos
{
    public class NewsGetDetailDto
    {
        public DateTime CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? DeletedBy { get; set; }
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public string ContinueReadingUrl { get; set; }
        public int CategoryId { get; set; }
    }
}
