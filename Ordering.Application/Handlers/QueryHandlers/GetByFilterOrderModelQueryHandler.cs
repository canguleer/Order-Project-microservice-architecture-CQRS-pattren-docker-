using AutoMapper;
using MediatR;
using Ordering.Application.Queries;
using Ordering.Application.Responses;
using Ordering.Domain.Entities;
using Ordering.Domain.FilterModels;
using Ordering.Domain.Repositories;
using OrderProject.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ordering.Application.Handlers
{
    public class GetByFilterOrderModelQueryHandler : IRequestHandler<GetByFilterOrderModelQuery, PagedList<Order>>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public GetByFilterOrderModelQueryHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }


        public async Task<PagedList<Order>> Handle(GetByFilterOrderModelQuery request, CancellationToken cancellationToken)
        {
            var filter = _mapper.Map<OrderFilterModel>(request);
            var orderList = _orderRepository.GetOrders(filter);

            return  orderList;
        }
    }
}
