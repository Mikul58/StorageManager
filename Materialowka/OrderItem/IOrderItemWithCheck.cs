using System;
using System.Collections.Generic;
using System.Text;

namespace Materialowka
{
    interface IOrderItemWithCheck :IOrderItem
    {
        bool IsChecked { get; set; }
    }
}
