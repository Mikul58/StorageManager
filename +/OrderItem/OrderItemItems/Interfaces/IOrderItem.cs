using System;
using System.Collections.Generic;
using System.Text;

namespace Materialowka.OrderItem
{
    public interface IOrderItem<T>
    {
        string ItemName { get; set; }
        T UniqueProperty { get; set; }
    }
}
