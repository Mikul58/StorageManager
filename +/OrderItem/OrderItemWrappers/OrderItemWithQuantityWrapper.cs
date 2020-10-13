using System;
using System.Collections.Generic;
using System.Text;

namespace Materialowka.OrderItem
{
    class OrderItemWithQuantityWrapper : IOrderItemWrapper
    {
        private int _quantity;
        public OrderItemWithQuantityWrapper(string itemName, string quantity)
        {
            WrapFromString(quantity);
            IOrderItemWithQuantity orderItemWithQuantity = new OrderItemWithQuantity(itemName, _quantity);
        }

        public void WrapFromString(string quantity)
        {
            _quantity = Int32.Parse(quantity);
        }
    }
}
