using System;
using System.Collections.Generic;
using System.Text;

namespace Materialowka
{
    public interface IOrder
    {
        string OrderStreet { get; set; }
        int OrderNumber { get; set; }
        DateTime OrderDay { get; set; }

    }
}
