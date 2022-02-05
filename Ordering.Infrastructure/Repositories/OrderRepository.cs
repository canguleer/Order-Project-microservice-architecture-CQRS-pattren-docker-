using Microsoft.EntityFrameworkCore;
using Ordering.Domain.Entities;
using Ordering.Domain.FilterModels;
using Ordering.Domain.Repositories;
using Ordering.Infrastructure.Data;
using Ordering.Infrastructure.Repositories.Base;
using OrderProject.Domain.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering.Infrastructure.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {

        private AppDbContext appDbContext { get => _context as AppDbContext; }

        public OrderRepository(AppDbContext context) : base(context)
        {

        }



        PagedList<Order> IOrderRepository.GetOrders(OrderFilterModel movieFilterModel)
        {
            var query = this._dbSet.AsQueryable();

            if (movieFilterModel.Statuses.Count() > 0)
            {
                query = query.Where(x => movieFilterModel.Statuses.Contains(x.Status));
            }

            if (movieFilterModel.StartDate != null && movieFilterModel.StartDate.ToString() != "1.01.0001 00:00:00")
            {
                query = query.Where(x => x.CreatedOn >= movieFilterModel.StartDate);


            }
            if (movieFilterModel.EndDate != null && movieFilterModel.EndDate.ToString() != "1.01.0001 00:00:00")
            {
                query = query.Where(x => x.CreatedOn <= movieFilterModel.EndDate);

            }

            if (!string.IsNullOrEmpty(movieFilterModel.SearchText))
            {
                string filterBy = movieFilterModel.SearchText.Trim().ToLower();

                query = query.Where(x => x.StoreName.ToLower().Contains(filterBy) || x.CustomerName.ToLower().Contains(filterBy));
            }

            if (!string.IsNullOrEmpty(movieFilterModel.SortBy))
            {
                query = query.Sort(movieFilterModel.SortBy);
            }
            return new PagedList<Order>(query, movieFilterModel.PageNumber, movieFilterModel.PageSize);
        }
    }
}

