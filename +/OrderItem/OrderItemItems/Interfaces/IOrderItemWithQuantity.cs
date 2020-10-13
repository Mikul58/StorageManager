using System;
using System.Collections.Generic;
using System.Text;

namespace Materialowka.OrderItem
{
    interface IOrderItemWithQuantity : IOrderItem
    {
        int Quantity { get; set; }

    }
}
