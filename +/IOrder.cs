using System;
using Materialowka.OrderItemFolder;
using System.Collections.Generic;
using System.Text;

namespace Materialowka
{
    public interface IOrder
    {

        void AddOrderItemToList(string itemName, string keyParameter);
        public void AddOrderStreet(string orderStreet);
        public void AddOrderNumber(int orderNumber);
    }
}
