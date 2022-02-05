using Microsoft.EntityFrameworkCore;
using Ordering.Domain.Repositories.Base;
using Ordering.Infrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ordering.Infrastructure.Repositories.Base
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public readonly AppDbContext _context;
        public readonly DbSet<TEntity> _dbSet;

        public Repository(AppDbContext context)
        {
            _context = context; //veritabanına erişir..
            _dbSet = context.Set<TEntity>(); //tablolara erişir
        }


        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _dbSet.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
            return entities;
        }

    }
}
