using Materialowka.OrderItem;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Materialowka
{
    public class Order : IOrder
    {
        public string OrderStreet { get; set; }
        public int OrderNumber { get; set; }
        public string OrderDay { get; set; }
        public List<IOrderItem<object>> OrderItems { get; set; }

        public Order()
        {
            OrderDay = DateTime.Now.ToString(new CultureInfo("PL-pl"));
        }

        public void AddOrderItemToList(IOrderItem<object> orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public void AddOrderStreet(string orderStreet)
        {
            OrderStreet = orderStreet;
        }

        public void AddOrderNumber(int orderNumber)
        {
            OrderNumber = orderNumber;
        }
    }
}
