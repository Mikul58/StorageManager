using System;
using System.Collections.Generic;
using System.Text;

namespace Materialowka.OrderItem
{
    class OrderItemWithCheckWrapper : IOrderItemWrapper
    {
        private bool _isChecked;
        public OrderItemWithCheckWrapper(string itemName, string isChecked)
        {
            WrapFromString(isChecked);
            IOrderItemWithCheck orderItemWithCheck = new OrderItemWithCheck(itemName, _isChecked);
        }

        public void WrapFromString(string isChecked)
        {
            _isChecked = Boolean.Parse(isChecked);
        }

    }
}
