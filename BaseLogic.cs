﻿using Lab.LINQ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.LINQ.Logic
{
    public class BaseLogic
    {
        protected readonly NorthWindContext context;

        public BaseLogic()
        { 
            context =  new NorthWindContext();
        
        }
    }
}
