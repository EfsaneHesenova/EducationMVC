using Education.Core.Models.Common;
using Education.DAL.Contexts;
using Education.DAL.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Education.DAL.Repositories.Implementations
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
           
        }
        DbSet<T> table => _context.Set<T>();

        public async Task CreateAsync(T entity)
        {
           await table.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            table.Remove(entity);   
        }

        public async Task<ICollection<T>> GetAllAsync()
        {
            return await table.ToListAsync();
        }

        public IQueryable<T> GetAllByCondition(Expression<Func<T,bool>> condition)
        {
            IQueryable<T> query = table.AsQueryable(); 
            query = query.Where(condition);
            return query;   
        }

        public async Task<T> GetByIdAsync(int id, bool isTracking, params string[] includes)
        {
            IQueryable<T> query = table.AsQueryable();
            if (isTracking)
            {
                query = query.AsNoTracking();
            }
            if(includes.Length > 0)
            {
                foreach (string include in includes)
                {
                   query = query.Include(include);
                }
            }
            T? entity = await table.SingleOrDefaultAsync(x => x.Id == id);
            return entity;
        }

        public async Task<bool> IsExist(int id)
        {
          return await table.AnyAsync(x => x.Id == id);
        }

        public async Task<int> SaveChangesAsync()
        {
            int rows = await _context.SaveChangesAsync();
            return rows;
        }

        public void Update(T entity)
        {
            table.Update(entity);
        }
    }
}
