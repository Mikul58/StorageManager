using System;
using System.Collections.Generic;
using System.Text;

namespace Materialowka.OrderItem
{
    public interface IOrder
    {
        string OrderStreet { get; set; }
        int OrderNumber { get; set; }
        string OrderDay { get; set; }
        List<IOrderItem<object>> OrderItems { get; set; }

        void AddOrderItemToList(IOrderItem<object> orderItem);
        public void AddOrderStreet(string orderStreet);
        public void AddOrderNumber(int orderNumber);
    }
}
