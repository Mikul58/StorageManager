using System;

namespace Materialowka
{
    public static class FactoryOrder
    {
        public static IOrder CreateOrder(IOrder order)
        {
            return order;
        }
    }
}
