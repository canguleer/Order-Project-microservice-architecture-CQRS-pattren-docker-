using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ordering.Domain.Entities;
using System;

namespace OrderProject.Infrastructure.Seeds
{
    class OrderSeed : IEntityTypeConfiguration<Order>
    {
        private readonly int[] _ids;
        public OrderSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(new Order { Id = _ids[0], BrandId = 3, Price = 17, StoreName = "Shopi", CustomerName = "Can Güler", CreatedOn = DateTime.Now, Status = Domain.Enums.Enums.OrderStatus.Created });
            builder.HasData(new Order { Id = _ids[1], BrandId = 5, Price = 55, StoreName = "Shopi", CustomerName = "Mehmet Güler", CreatedOn = DateTime.Now.AddDays(-10), Status = Domain.Enums.Enums.OrderStatus.Canceled });
            builder.HasData(new Order { Id = _ids[2], BrandId = 2, Price = 60, StoreName = "Shopi", CustomerName = "Ahmet Güler", CreatedOn = DateTime.Now.AddDays(-50), Status = Domain.Enums.Enums.OrderStatus.Failed });
            builder.HasData(new Order { Id = _ids[3], BrandId = 2, Price = 90, StoreName = "Shopi", CustomerName = "Feyza Güler", CreatedOn = DateTime.Now.AddDays(-10), Status = Domain.Enums.Enums.OrderStatus.Completed });
            builder.HasData(new Order { Id = _ids[4], BrandId = 8, Price = 70, StoreName = "Shopi", CustomerName = "Enise Güler", CreatedOn = DateTime.Now.AddDays(-5), Status = Domain.Enums.Enums.OrderStatus.Created });
            builder.HasData(new Order { Id = _ids[5], BrandId = 7, Price = 50, StoreName = "Shopi", CustomerName = "Adem Güler", CreatedOn = DateTime.Now.AddDays(-9), Status = Domain.Enums.Enums.OrderStatus.InProgress });
            builder.HasData(new Order { Id = _ids[6], BrandId = 6, Price = 220, StoreName = "Shopi", CustomerName = "Şimşek Güler", CreatedOn = DateTime.Now.AddDays(-65), Status = Domain.Enums.Enums.OrderStatus.Created });
            builder.HasData(new Order { Id = _ids[7], BrandId = 5, Price = 87, StoreName = "Shopi", CustomerName = "Abdullah Güler", CreatedOn = DateTime.Now.AddDays(-88), Status = Domain.Enums.Enums.OrderStatus.Created });
            builder.HasData(new Order { Id = _ids[8], BrandId = 21, Price = 65, StoreName = "Shopi", CustomerName = "Nurullah Güler", CreatedOn = DateTime.Now.AddDays(-11), Status = Domain.Enums.Enums.OrderStatus.Created });
            builder.HasData(new Order { Id = _ids[9], BrandId = 14, Price = 65, StoreName = "Shopi", CustomerName = "Enes Güler", CreatedOn = DateTime.Now.AddDays(-7), Status = Domain.Enums.Enums.OrderStatus.Created });
            builder.HasData(new Order { Id = _ids[10], BrandId = 2, Price = 87, StoreName = "Shopi", CustomerName = "Emel Güler", CreatedOn = DateTime.Now.AddDays(-10), Status = Domain.Enums.Enums.OrderStatus.Created });
         
        }
    }
}
