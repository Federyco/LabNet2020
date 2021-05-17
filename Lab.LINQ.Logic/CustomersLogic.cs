using Lab.LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.LINQ.Logic
{
    public class CustomersLogic :  BaseLogic
    {

        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public void whereExecutionPuntoUno(string input)
        {
           
            try
            {
                var query = context.Customers.Where(c => c.CustomerID == input).ToList();
                foreach (var item in query)
                {
                    Console.WriteLine($"\nCustomer ID: {item.CustomerID} - Name: {item.ContactName} - Company: {item.CompanyName} - Title: {item.ContactTitle} - Address: {item.Address} - City: {item.City} - Region: {item.Region} - CP: {item.PostalCode} - Country: {item.Country} - Phone: {item.Phone} - Fax: {item.Fax}");
                }
            }
            catch (NullReferenceException null_ex)
            {
                Console.WriteLine($"Mensaje: { null_ex.Message}");
                Console.WriteLine($"StrackTrace: { null_ex.StackTrace}");
            }
            catch (ArgumentException argu_ex)
            {
                Console.WriteLine($"Mensaje: { argu_ex.Message}");
                Console.WriteLine($"StrackTrace: { argu_ex.StackTrace}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Mensaje: { ex.Message}");
                Console.WriteLine($"StrackTrace: { ex.StackTrace}");
            }
            


        }
        public void whereExecutionPuntoCuatro()
        {

            try
            {
                string region_de_busqueda = "WA";
                var query = context.Customers.Where(c => c.Region == region_de_busqueda).ToList();

                if (query.Count() > 0)
                {
                    foreach (var item in query)
                    {
                        Console.WriteLine($"\nCustomer ID: {item.CustomerID} - Name: {item.ContactName} - Company: {item.CompanyName} - Title: {item.ContactTitle} - Address: {item.Address} - City: {item.City} - Region: {item.Region} - CP: {item.PostalCode} - Country: {item.Country} - Phone: {item.Phone} - Fax: {item.Fax}");
                    }

                }
                
            }
            catch (NullReferenceException null_ex)
            {
                Console.WriteLine($"Mensaje: { null_ex.Message}");
                Console.WriteLine($"StrackTrace: { null_ex.StackTrace}");
            }
            catch (ArgumentException argu_ex)
            {
                Console.WriteLine($"Mensaje: { argu_ex.Message}");
                Console.WriteLine($"StrackTrace: { argu_ex.StackTrace}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Mensaje: { ex.Message}");
                Console.WriteLine($"StrackTrace: { ex.StackTrace}");
            }



        }

        public void whereExecutionPuntoSeis()
        {

            try
            {
                string busqueda_customers = "";
                string busqueda_2_customers = " ";
                var query = context.Customers.Where(c => c.CustomerID != busqueda_customers || c.CustomerID != busqueda_2_customers).ToList();
                // forma 2 llamando al metodo ya existente
                query2 = this.GetAll();
                Console.WriteLine(query2);
                foreach (var item in query)
                {
                    Console.WriteLine("Mayusculas");
                    Console.WriteLine($"\n{item.ContactName.ToUpper()}");
                    Console.WriteLine("*******************************");

                }
                foreach (var item in query)
                {
                    Console.WriteLine("Minusculas");
                    Console.WriteLine($"\n{item.ContactName.ToLower()}");
                    Console.WriteLine("*******************************");

                }
            }
            catch (NullReferenceException null_ex)
            {
                Console.WriteLine($"Mensaje: { null_ex.Message}");
                Console.WriteLine($"StrackTrace: { null_ex.StackTrace}");
            }
            catch (ArgumentException argu_ex)
            {
                Console.WriteLine($"Mensaje: { argu_ex.Message}");
                Console.WriteLine($"StrackTrace: { argu_ex.StackTrace}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Mensaje: { ex.Message}");
                Console.WriteLine($"StrackTrace: { ex.StackTrace}");
            }



        }
        public void whereExecutionPuntoSiete()
        {
            DateTime chequeo = new DateTime(1997,01,01);

            try
            {
                var query = from orden in context.Orders
                            join cliente in context.Customers
                            on new { orden.CustomerID }
                                equals new { cliente.CustomerID }
                            where cliente.Region == "WA" && orden.OrderDate > chequeo
                            select new { orden.OrderDate, cliente.Region, cliente.CustomerID }; 

                foreach (var item in query)
                {
                    Console.WriteLine($"\nOrder Date: {item.OrderDate} - Region: {item.Region} - ID: {item.CustomerID}");
                    Console.WriteLine("*******************************************************************************");

                }
               
            }
            catch (NullReferenceException null_ex)
            {
                Console.WriteLine($"Mensaje: { null_ex.Message}");
                Console.WriteLine($"StrackTrace: { null_ex.StackTrace}");
            }
            catch (ArgumentException argu_ex)
            {
                Console.WriteLine($"Mensaje: { argu_ex.Message}");
                Console.WriteLine($"StrackTrace: { argu_ex.StackTrace}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Mensaje: { ex.Message}");
                Console.WriteLine($"StrackTrace: { ex.StackTrace}");
            }
        }

        public void whereExecutionPuntoOcho()
        {
            try
            {
                var query = (from clientes in context.Customers
                            where clientes.Region == "WA" 
                            orderby clientes.Region descending
                            select new {clientes.CustomerID, clientes.ContactName, clientes.Region }).Take(3);
                foreach (var item in query)
                {

                    Console.WriteLine($"\nOrder Date: {item.CustomerID} - Region: {item.ContactName} - ID: {item.Region}");
                    Console.WriteLine("*******************************************************************************");

                }

            }
            catch (NullReferenceException null_ex)
            {
                Console.WriteLine($"Mensaje: { null_ex.Message}");
                Console.WriteLine($"StrackTrace: { null_ex.StackTrace}");
            }
            catch (ArgumentException argu_ex)
            {
                Console.WriteLine($"Mensaje: { argu_ex.Message}");
                Console.WriteLine($"StrackTrace: { argu_ex.StackTrace}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Mensaje: { ex.Message}");
                Console.WriteLine($"StrackTrace: { ex.StackTrace}");
            }
        }
        public void whereExecutionPuntoTrece()
        {
            /*      SELECT [Order Details].Quantity
                    FROM dbo.Customers AS clientes
                    INNER JOIN Orders on clientes.CustomerID = Orders.CustomerID
                    INNER JOIN [Order Details] on Orders.OrderDate = [Order Details].OrderID;*/
            try
            {
                var query = from clientes in context.Customers
                            join orden in context.Orders
                            on new { clientes.CustomerID }
                                equals new { orden.CustomerID }
                            join detalle in context.Order_Details
                            on new { orden.OrderID}
                                equals new { detalle.OrderID}
                            join productos in context.Products
                            on new { detalle.ProductID}
                                equals new { productos.ProductID}
                            select new { detalle.Quantity, clientes.CustomerID, clientes.ContactName, orden.OrderID, productos.ProductName};
                foreach (var item in query)
                {

                    Console.WriteLine($"\n  Client ID: {item.CustomerID} - Nombre: {item.ContactName} - Producto: {item.ProductName} - Cantidad: {item.Quantity} -- Order ID: {item.OrderID}");
                    Console.WriteLine("*******************************************************************************");

                }

            }
            catch (NullReferenceException null_ex)
            {
                Console.WriteLine($"Mensaje: { null_ex.Message}");
                Console.WriteLine($"StrackTrace: { null_ex.StackTrace}");
            }
            catch (ArgumentException argu_ex)
            {
                Console.WriteLine($"Mensaje: { argu_ex.Message}");
                Console.WriteLine($"StrackTrace: { argu_ex.StackTrace}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Mensaje: { ex.Message}");
                Console.WriteLine($"StrackTrace: { ex.StackTrace}");
            }
        }


    }
}
