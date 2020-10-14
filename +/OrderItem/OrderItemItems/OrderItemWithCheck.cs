using System;
using System.Collections.Generic;
using System.Text;

namespace Materialowka.OrderItem
{
    public class OrderItemWithCheck : IOrderItem<bool>
    {
        public string ItemName { get; set; }
        public bool UniqueProperty { get; set; }

        public OrderItemWithCheck(string itemName, bool uniqueProperty)
        {
            ItemName = itemName;
            UniqueProperty = uniqueProperty;
        }
    }
}