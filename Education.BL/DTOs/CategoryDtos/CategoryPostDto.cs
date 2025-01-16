﻿using Education.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.BL.DTOs.CategoryDtos
{
    public class CategoryPostDto
    {
        public string Title { get; set; }
        public ICollection<News> News { get; set; }
    }
}
