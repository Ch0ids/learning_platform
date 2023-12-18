using DAL.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class BaseRepo<TEntity, TKey> : IBaseRepo<TEntity, TKey>
        where TEntity : BaseEntity<TKey>
    {
        public virtual void Add(TEntity entity)
        {

        }

        public virtual void AddMultiple(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public virtual void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<TEntity> DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public virtual void DeleteMultiple(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<TEntity> Get()
        {
            throw new NotImplementedException();
        }

        public virtual Task<TEntity> GetSingleAsync(TKey id)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
