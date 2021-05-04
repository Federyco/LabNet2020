using Lab.LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.LINQ.Logic
{
    public class ProductsLogic : BaseLogic
    {


        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }
        public void whereExecutionPuntoDos()
        {
            try
            {
                int valor_de_busqueda =0;
                var query = context.Products.Where(p => p.UnitsInStock == valor_de_busqueda).ToList();
                foreach (var item in query)
                {
                    Console.WriteLine($"\n ID: {item.ProductID} - Nombre: {item.ProductName} - Supplier ID: {item.SupplierID} - Category ID: {item.CategoryID} - Quantity: {item.QuantityPerUnit} - Unit Price: {item.UnitPrice} - Stock: {item.UnitsInStock} - Ordered Units: {item.UnitsOnOrder} - Reorder Level: {item.ReorderLevel}");
                    Console.WriteLine("************************************************************************************************************************************************************************************************************************************************************************************************");
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
        public void whereExecutionPuntoTres()
        {
            try
            {
                int valor_de_busqueda = 0;
                int precio_minimo = 3;
                var query = context.Products.Where(p => p.UnitsInStock > valor_de_busqueda && p.UnitPrice > precio_minimo).ToList();
                foreach (var item in query)
                {
                    Console.WriteLine($"\n ID: {item.ProductID} - Nombre: {item.ProductName} - Supplier ID: {item.SupplierID} - Category ID: {item.CategoryID} - Quantity: {item.QuantityPerUnit} - Unit Price: {item.UnitPrice} - Stock: {item.UnitsInStock} - Ordered Units: {item.UnitsOnOrder} - Reorder Level: {item.ReorderLevel}");
                    Console.WriteLine("************************************************************************************************************************************************************************************************************************************************************************************************");
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
        public void whereExecutionPuntoCinco()
        {
            try
            {
                int id_de_busqueda = 789;
                var query = context.Products.Where(p => p.ProductID == id_de_busqueda).ToList();
                foreach (var item in query)
                {
                    if (item?.ProductID == null)
                    {

                        Console.WriteLine($"Valor Nulo localizado en el ID: {item.ProductID} - {item.ProductName}");
                        Console.WriteLine("**********************************************************************");
                    }
                    else 
                    {
                        Console.WriteLine($"Valores Encontrados: {item.ProductID} - {item.ProductName}");
                        Console.WriteLine("***********************************************************");
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
    }
}
