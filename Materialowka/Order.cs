using System;
using System.Collections.Generic;
using System.Text;

namespace Materialowka
{
    public class Order : IOrder
    {
        List<IOrderItem> _orderItemsList;
        public int OrderNumber { get; set; }
        public DateTime OrderDay { get ; set; }

        public Order(List<IOrderItem> OrderItemsList)
        {
            this._orderItemsList = OrderItemsList;
        }
    }
}
