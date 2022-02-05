using MediatR;
using Ordering.Application.Responses;
using Ordering.Domain.Entities;
using OrderProject.Domain.Helpers;
using System;
using System.Collections.Generic;
using static OrderProject.Domain.Enums.Enums;

namespace Ordering.Application.Queries
{
    public class GetByFilterOrderModelQuery: IRequest<PagedList<Order>>
    {
        public int PageSize { get; set; } = 10;
        public int PageNumber { get; set; } = 1;
        public string SearchText { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public List<OrderStatus> Statuses { get; set; }
        public string SortBy { get; set; }

        public GetByFilterOrderModelQuery(int pageSize,int pageNumber, string searchText,DateTime startDate,DateTime endDate,List<OrderStatus> statuses,string sortBy)
        {

            PageSize = pageSize;
            PageNumber = pageNumber;
            SearchText = searchText;
            StartDate = startDate;
            EndDate = endDate;
            Statuses = statuses;
            SortBy = sortBy;


        }
    }
}
