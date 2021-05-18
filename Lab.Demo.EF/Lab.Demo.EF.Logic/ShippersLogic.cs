using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
    public class ShippersLogic : BaseLogic, IABMLogic<Shippers>
    {
        public void Add(Shippers newShipper)
        {
            throw new NotImplementedException();
        }

        public string deleteCustomer(string id)
        {
            throw new NotImplementedException();
        }

        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }

        public void updateCustomer(Shippers updateShippers)
        {
            throw new NotImplementedException();
        }
    }
}
