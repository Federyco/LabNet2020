﻿using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T newCustomer);

        void deleteCustomer(string id);

        void updateCustomer(string id, string newContactName);
    }
}