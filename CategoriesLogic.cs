using Lab.LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.LINQ.Logic
{
    public class CategoriesLogic : BaseLogic
    {

        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }

        public void whereExecutionPuntoOnce()
        {
            try
            {
                var query = from categorias in context.Categories
                            select categorias;
                foreach (var item in query)
                {
                    Console.WriteLine($"Nombre de Categoria: {item.CategoryName}");
                    Console.WriteLine("**********************************************************************");
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
