using Materialowka.OrderItemFolder;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Materialowka.OrderItemFolder
{
    public class OrderItem : IOrderItem
    {
        public string _itemName;
        public string _keyParameter;

        public OrderItem(string itemName, string keyParameter)
        {
            _itemName = itemName;
            _keyParameter = keyParameter;
        }
    }
}