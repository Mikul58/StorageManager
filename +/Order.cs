using System;
using System.Collections.Generic;
using System.Text;

namespace Materialowka
{
    public class Order : IOrder
    {
        List<IOrderItem> _orderItemsList;
        public string OrderStreet { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDay { get; set; }

        public Order()
        {
            this._orderItemsList.Add()
        }
    }
}
