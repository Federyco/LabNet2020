using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
   public  class CustomersLogic : BaseLogic, IABMLogic<Customers>
    {
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public void Add(Customers newCustomer)
        {
            context.Customers.Add(newCustomer);

            try
            {
                //siempre luego de realizar un cambio los guardo
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
        public string deleteCustomer(string deleteID)
        {
            // customerAEliminar = context.Customers.FirstOrDefault(c => c.CustomerID == id);

            //customerAEliminar = context.Customers.Single(c => c.CustomerID == id);

            //customerAEliminar = context.Customers.SingleOrDefault(c => c.CustomerID == id);

            //busqueda por primary key
            var customerAEliminar = context.Customers.Find(deleteID);
            if (customerAEliminar != null)
            {
                context.Customers.Remove(customerAEliminar);
                
                try
                {
                    //siempre luego de realizar un cambio los guardo
                    context.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                return deleteID;
            }
            else 
            {
                deleteID = "ERROR";
                return deleteID;
            }

        }

        public void updateCustomer(Customers customer)
        {
            var customerUpdate = context.Customers.Find(customer.CustomerID);

            customerUpdate.CustomerID = customer.CustomerID;
            customerUpdate.CompanyName = customer.CompanyName;
            customerUpdate.ContactName = customer.ContactName;
            customerUpdate.ContactTitle = customer.ContactTitle;
            customerUpdate.Address = customer.Address;
            customerUpdate.City = customer.City;
            customerUpdate.Region = customer.Region;
            customerUpdate.PostalCode = customer.PostalCode;
            customerUpdate.Country = customer.Country;
            customerUpdate.Phone = customer.Phone;
            customerUpdate.Fax = customer.Fax;


            try
            {
                //siempre luego de realizar un cambio los guardo
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public bool SearchForExistence(string searchThisID)
        {
            try
            {
                var seeekAndDestroy = context.Customers.Find(searchThisID);
                if (seeekAndDestroy == null)
                {
                    return false;
                }
                else 
                {
                    return true;
                }
 
                    
            }
            catch (InvalidOperationException invalid_ex)
            {
                Console.WriteLine($" No puedo manejar este operador : {invalid_ex}");
                return false;
            }
            catch (NullReferenceException null_ex)
            {
                //si el objeto devuelto es un valor nulo, atrapo el error para que mi programa continue sin el crasheo
                Console.WriteLine($"Is NULL: {null_ex.Message}");
                Console.WriteLine($" StackTrace: {null_ex.StackTrace}");
                return false;
            }
            catch (Exception)
            {

                throw;

            }


        }

        public Customers getOneCustomer(string id)
        {          
            return context.Customers.Find(id);   
        }

       
    }
}
