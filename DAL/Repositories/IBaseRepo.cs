using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IBaseRepo<TEntity, in TKey> where TEntity : class
    {
        IQueryable<TEntity> Get();
        Task<TEntity> GetSingleAsync(TKey id);
        void Add(TEntity entity);
        void AddMultiple(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        Task<TEntity> DeleteAsync();
        void DeleteMultiple(IEnumerable<TEntity> entities);
    }
}
