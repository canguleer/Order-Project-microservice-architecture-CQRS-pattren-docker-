using Ordering.Application.Responses;
using OrderProject.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESourcing.Order.OutputModel
{
    public class OrderOutputModel
    {
        public PagingHeader Paging { get; set; }
        //public List<LinkInfo> Links { get; set; }
        public List<OrderResponse> Items { get; set; }
        public string SortBy { get; set; }
        public string SearchText { get; set; }
    }
}
