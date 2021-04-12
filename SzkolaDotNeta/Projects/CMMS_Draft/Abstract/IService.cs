using System;
using System.Collections.Generic;

namespace CMMS_Draft
{
    public interface IService<T>
    {
        /* CRUD - */

        List<T> Items { get; set; }
        int AddItem(T item);
        int UpdateItem(T item);
        void RemoveItem(T item);

    }
}