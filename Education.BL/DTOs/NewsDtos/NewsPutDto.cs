using Education.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.BL.DTOs.NewsDtos
{
    public class NewsPutDto
    {
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public string ContinueReadingUrl { get; set; }
        public int CategoryId { get; set; }
        public int Id { get; set; }
    }
}
