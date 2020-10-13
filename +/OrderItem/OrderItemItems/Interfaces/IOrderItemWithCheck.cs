using Materialowka.OrderItem;
using System;
using System.Collections.Generic;
using System.Text;

namespace Materialowka
{
    public interface IOrderItemWithCheck : IOrderItem
    {
        bool Check { get; set; }
    }
}
