using System;
using System.Collections.Generic;
using System.Text;

namespace Materialowka.OrderItem.OrderItemCreator
{
    public class OrderItemCheckCreator : IOrderItemCreator<bool>
    {
        public IOrderItem<bool> OrderItem { get; set; }
        public OrderItemCheckCreator(IOrderItem<bool> orderItem)
        {
            OrderItem = orderItem;
        }
    }
}
