using System;
using System.Collections.Generic;
using System.Text;

namespace Materialowka
{
    class OrderItemWithCheck : IOrderItemWithCheck
    {
        //Do a generic <T> class, where you can add items to list (or maybe IOrderItem List)
        public string ItemName { get; set; }
        public bool IsChecked { get; set; }
    }
}
