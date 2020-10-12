using System;
using System.Collections.Generic;
using System.Text;

namespace Materialowka
{
    public interface IOrderItemWithQuantity : IOrderItem
    {
        int Quantity { get; set; }
    }
}
