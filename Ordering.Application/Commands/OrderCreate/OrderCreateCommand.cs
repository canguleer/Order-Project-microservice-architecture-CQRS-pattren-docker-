using MediatR;
using Ordering.Application.Responses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static OrderProject.Domain.Enums.Enums;

namespace Ordering.Application.Commands.OrderCreate
{
    public class OrderCreateCommand : IRequest<OrderResponse>
    {
        public int? Id { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "{0} alanı 0 'dan büyük bir değer olmalıdır.")]
        public int BrandId { get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "{0} alanı 1 'dan büyük bir değer olmalıdır.")]
        public decimal Price { get; set; }
        public string StoreName { get; set; }
        public string CustomerName { get; set; }
        public DateTime CreatedOn { get; set; }
        public OrderStatus Status { get; set; }
    }
}
