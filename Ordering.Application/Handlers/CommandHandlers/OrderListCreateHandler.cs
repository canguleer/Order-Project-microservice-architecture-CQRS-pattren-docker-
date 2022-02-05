using AutoMapper;
using MediatR;
using Ordering.Application.Commands.OrderCreate;
using Ordering.Application.Responses;
using Ordering.Domain.Entities;
using Ordering.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ordering.Application.Handlers.CommandHandlers
{
    public class OrderListCreateHandler : IRequestHandler<OrderListCreateCommand, List<OrderResponse>>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderListCreateHandler(
            IOrderRepository orderRepository,
            IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }



      

        public async Task<List<OrderResponse>> Handle(OrderListCreateCommand request, CancellationToken cancellationToken)
        {
            var orderEntity = _mapper.Map<List<Order>>(request.CreateOrderList);

            if (orderEntity == null)
                throw new ApplicationException("Entity could not be mapped!");

            var order = await _orderRepository.AddRangeAsync(orderEntity);

            var orderResponse = _mapper.Map<List<OrderResponse>>(order);

            return orderResponse;
        }


    }
}
