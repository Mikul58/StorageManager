using System;
using System.Collections.Generic;
using System.Text;

namespace Materialowka.OrderItem
{
    public class OrderItemWithCheck : IOrderItemWithCheck
    {
        public string ItemName { get; set; }
        public bool Check { get; set; }
        public OrderItemWithCheck(string itemName, bool check)
        {
            ItemName = itemName;
            Check = check;
        }
    }
}