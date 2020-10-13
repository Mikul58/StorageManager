using System;

namespace Materialowka
{
    public class FactoryOrder
    {
        private IOrder _order;

        public FactoryOrder(IOrder order)
        {
            _order = order;
        }
    }
}
