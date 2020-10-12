using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Materialowka
{
    public static class ListOfGenericItemCreator<T>
    {
        static List<T> createdList;
        static List<T> CreateList()
        {
            return createdList;
        }
    }
}
