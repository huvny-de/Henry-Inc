using Henry_Inc.Data.Entities;
using Henry_Inc.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Henry_Inc.ViewModels.Catalogs.Orders
{
    public class CreateOrderRequest
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

    }
}
