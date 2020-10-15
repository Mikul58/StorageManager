using Materialowka.OrderItemFolder;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;

namespace Materialowka
{

    public class Order : IOrder
    {
        private List<IOrderItem> _orderItems;
        private IOrderItem _orderItem;

        private string _orderStreet;
        private string _orderDay;

        private int _orderNumber;
        public Order()
        {
            _orderItem = new OrderItem(null, null);
            _orderItems = new List<IOrderItem>();
            _orderDay = DateTime.Now.ToString(new CultureInfo("PL-pl"));
        }

        public void AddOrderItemToList(string itemName, string keyParameter)
        {

            IOrderItem _orderItem = new OrderItem(itemName, keyParameter);
            _orderItems.Add(_orderItem);
        }

        public void AddOrderStreet(string orderStreet)
        {
            _orderStreet = orderStreet;
        }

        public void AddOrderNumber(int orderNumber)
        {
            _orderNumber = orderNumber;
        }
    }
}
