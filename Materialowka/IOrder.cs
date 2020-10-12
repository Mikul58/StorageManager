using System;
using System.Collections.Generic;
using System.Text;

namespace Materialowka
{
    public interface IOrder
    {
        int OrderNumber { get; set; }
        DateTime OrderDay { get; set; }

    }
}
