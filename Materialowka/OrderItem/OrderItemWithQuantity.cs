using Materialowka;
using System;
using System.Collections.Generic;
using System.Text;

namespace Materialowka
{
    public class OrderItemWithQuantity : IOrderItemWithQuantity
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
    }
}
