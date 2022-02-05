using AutoMapper;
using ESourcing.Order.Filters;
using ESourcing.Order.OutputModel;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ordering.Application.Commands.OrderCreate;
using Ordering.Application.Queries;
using Ordering.Application.Responses;
using Ordering.Domain.FilterModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ESourcing.Order.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<OrderController> _logger;
        private readonly IMapper _mapper;

        public OrderController(IMediator mediator, ILogger<OrderController> logger, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("GetOrdersByFilter")]
        [ProducesResponseType(typeof(IEnumerable<OrderResponse>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult Get([FromQuery] OrderFilterModel filter)
        {
            var query = new GetByFilterOrderModelQuery(filter.PageSize, filter.PageNumber, filter.SearchText, Convert.ToDateTime(filter.StartDate), Convert.ToDateTime(filter.EndDate), filter.Statuses, filter.SortBy);

            var model = _mediator.Send(query);

            Response.Headers.Add("X-Pagination", model.Result.GetHeader().ToJson());

            var outputModel = new OrderOutputModel
            {
                Paging = model.Result.GetHeader(),
                //Links = GetLinks(model),
                Items = _mapper.Map<List<OrderResponse>>(model.Result.List),
                SearchText = filter.SearchText,
                SortBy = filter.SortBy
            };
            return Ok(outputModel);
        }

        [ValidationFilter]
        [HttpPost(Name = "CreateOrderList")]
        [ProducesResponseType(typeof(OrderResponse), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<List<OrderResponse>>> SaveAll([FromBody] OrderListCreateCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }





        //[HttpPost]
        //[ProducesResponseType(typeof(OrderResponse), (int)HttpStatusCode.OK)]
        //public async Task<ActionResult<OrderResponse>> Save([FromBody] OrderCreateCommand command)
        //{
        //    var result = await _mediator.Send(command);
        //    return Ok(result);
        //}
    }
}
