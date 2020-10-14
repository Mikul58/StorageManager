using System;
using System.Collections.Generic;
using System.Text;

namespace Materialowka.OrderItem.OrderItemCreator
{
    public class OrderItemQuantityCreator : IOrderItemCreator<int>
    {
        public IOrderItem<int> OrderItem { get; set; }
        public OrderItemQuantityCreator(IOrderItem<int> orderItem)
        {
            OrderItem = orderItem;
        }
    }
}
