using System;
using System.Collections.Generic;
using System.Text;

namespace Materialowka.OrderItem
{
    public interface IOrderItemWrapper
    {
        void WrapFromString(string itemToWrap);
    }
}
