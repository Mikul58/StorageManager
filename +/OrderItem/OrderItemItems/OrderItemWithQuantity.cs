using Materialowka;
using System;
using System.Collections.Generic;
using System.Text;

namespace Materialowka.OrderItem
{
    public class OrderItemWithQuantity : IOrderItemWithQuantity
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public OrderItemWithQuantity(string itemName, int quantity)
        {
            ItemName = itemName;
            Quantity = quantity;
        }
    }
}
