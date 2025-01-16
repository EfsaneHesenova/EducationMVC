using Education.Core.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Education.DAL.Repositories.Abstractions
{
    public interface IRepository<T> where T : BaseEntity, new()
    {
        Task CreateAsync(T entity);
        Task<ICollection<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id, bool isTracking, params string[] includes);
        IQueryable<T> GetAllByCondition(Expression<Func<T, bool>> condition);
        void Update(T entity);
        void Delete(T entity);
        Task<bool> IsExist(int id);
        Task<int> SaveChangesAsync();

    }
}
