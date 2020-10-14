using Materialowka.OrderItem.OrderItemCreator;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Materialowka.OrderItem
{
    public interface IOrderItemCreator<T>
    {
        IOrderItem<T> OrderItem { get; set; }
    }
}
