using Ordering.Domain.Entities;
using Ordering.Domain.FilterModels;
using Ordering.Domain.Repositories.Base;
using OrderProject.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Domain.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        PagedList<Order> GetOrders(OrderFilterModel movieFilterModel);
    }
}
