using Materialowka;
using System;
using System.Collections.Generic;
using System.Text;

namespace Materialowka.OrderItem
{
    public class OrderItemWithQuantity : IOrderItem<int>
    {
        public string ItemName { get; set; }
        public int UniqueProperty { get; set; }
        public OrderItemWithQuantity(string itemName, int uniqueProperty)
        {
            ItemName = itemName;
            UniqueProperty = uniqueProperty;
        }
    }
}
