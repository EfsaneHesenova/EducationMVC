using Education.Core.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Core.Models
{
    public class News : AuditableEntity
    {
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public string ContinueReadingUrl { get; set; }
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
    }
}
