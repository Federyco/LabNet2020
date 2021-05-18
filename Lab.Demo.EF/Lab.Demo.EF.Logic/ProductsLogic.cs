using Lab.Demo.EF.Data;
using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
    public class ProductsLogic : BaseLogic, IABMLogic<Products>
    {
        public void Add(Products newCustomer)
        {
            throw new NotImplementedException();
        }

        public string deleteCustomer(string id)
        {
            throw new NotImplementedException();
        }

        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }


        public void updateCustomer(Products updateProducts)
        {
            throw new NotImplementedException();
        }
    }
}
