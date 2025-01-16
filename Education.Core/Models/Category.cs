using Education.Core.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Core.Models
{
    public class Category : AuditableEntity
    {
        public string Title { get; set; }
        public ICollection<News> News { get; set; }
    }
}
