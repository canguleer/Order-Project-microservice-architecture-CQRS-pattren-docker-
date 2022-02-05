using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ordering.Domain.Repositories.Base
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task <IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities);
        Task<TEntity> AddAsync(TEntity entity);
    }
}
