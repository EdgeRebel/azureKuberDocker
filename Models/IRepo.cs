﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagementProject.Models
{
    public interface IRepo<T>
    {
        public void AddItem(T item);
        public IEnumerable<T> GetItems();
    }
}
