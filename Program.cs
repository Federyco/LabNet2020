using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Demo.EF.Entities;
using Lab.Demo.EF.Logic;

namespace Lab.Demo.EF.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductsLogic productlogic = new ProductsLogic();

            //foreach (Products product in productlogic.GetAll())
            //{
            //     Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
            // }


           NewCustomerApproaches("IIIEA", "Federico", "MinDzDev");
           CustomersLogic customerLogic = new CustomersLogic();
            foreach (var item in customerLogic.GetAll())
            {
                Console.WriteLine($"{item.CustomerID} - {item.ContactName} - {item.CompanyName}");
            }

           Console.ReadLine();

           
        }
        public static void NewCustomerApproaches(string customerID, string contactName, string compranyName)
        {
            CustomersLogic customerLogic = new CustomersLogic();
            try
            {
                customerLogic.Add(new Customers
                {
                    CustomerID = customerID,
                    ContactName = contactName,
                    CompanyName = compranyName
                });
            }
            catch (DbEntityValidationException ex)
            {

                Console.WriteLine("\n Encontré un error: ", ex.Message);
                Console.WriteLine("\n Este es el StackTrace: ", ex.StackTrace);
            }
            

        }
    }
}
