using Lab.Demo.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
    public class BaseLogic
    {
        // debido al readonly solo puedo instanciar context en la linea donde se creó, o en su constructor
        protected readonly NorthWindContext context;

        public BaseLogic()
        {
            context = new NorthWindContext();
        }
    }
}
