using Education.Core.Models;
using Education.DAL.Contexts;
using Education.DAL.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.DAL.Repositories.Implementations
{
    public class NewsRepository : Repository<News>, INewsRepository
    {
        public NewsRepository(AppDbContext context) : base(context)
        {
        }
    }
}
