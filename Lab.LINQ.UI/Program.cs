using Lab.LINQ.Entities;
using Lab.LINQ.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.LINQ.UI
{
    class Program
    {
        public static string customerID;

        static void Main(string[] args)
        {

            CustomersLogic customerslogic = new CustomersLogic();
            string ingreso = "";
            bool continuar = true;

            while (continuar == true)
            {
                Console.WriteLine("Menu del Ejercicio 5, LINQ");
                Console.WriteLine("Ingrese el numero correspondiente al ejercicio para ejecutar la consulta");
                Console.WriteLine("Ingrese 0 para salir");
                ingreso = Console.ReadLine();
                if (ingreso == "1")
                {
                    puntoUno();
                }
                if (ingreso == "2")
                {
                    puntoDos();
                }
                if (ingreso == "3")
                {
                    puntoTres();
                }
                if (ingreso == "4")
                {
                    puntoCuatro();
                }
                if (ingreso == "5")
                {
                    puntoCinco();
                }
                if (ingreso == "6")
                {
                    puntoSeis();
                }
                if (ingreso == "7")
                {
                    puntoSiete();
                }
                if (ingreso == "8")
                {
                    puntoOcho();
                }
                if (ingreso == "9")
                {
                    puntoNueve();
                }
                if (ingreso == "10")
                {
                    puntoDiez();
                }
                if (ingreso == "11")
                {
                    puntoOnce();
                }
                if (ingreso == "12")
                {
                    puntoDoce();
                }
                if (ingreso == "13")
                {
                    puntoTrece();
                }
                if (ingreso == "0")
                {
                    continuar = false;
                    Console.WriteLine("Saliendo del Sistema");
                }
            }

        }
        public static void puntoUno()
        {
            CustomersLogic customerPuntoUno = new CustomersLogic();
            Console.WriteLine("1. Query para devolver objeto customer.");
            Console.WriteLine("Ingrese el Customer ID que desea buscar: ");
            customerID = Console.ReadLine();
            customerPuntoUno.whereExecutionPuntoUno(customerID);
            Console.ReadLine();
        }
        public static void puntoDos()
        {
            ProductsLogic productosPuntoDos = new ProductsLogic();
            Console.WriteLine("2. Query para devolver todos los productos sin stock");
            productosPuntoDos.whereExecutionPuntoDos();
            Console.ReadLine();
        }

        public static void puntoTres()
        {
            ProductsLogic productosPuntoTres = new ProductsLogic();
            Console.WriteLine("3. Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad");
            productosPuntoTres.whereExecutionPuntoTres();
            Console.ReadLine();
        }
        public static void puntoCuatro()
        {
            CustomersLogic customerPuntoCuatro = new CustomersLogic();
            Console.WriteLine("4. Query para devolver todos los customers de Washington");
            customerPuntoCuatro.whereExecutionPuntoCuatro();
            Console.ReadLine();
        }

        public static void puntoCinco()
        {
            ProductsLogic productosPuntoCinco = new ProductsLogic();
            Console.WriteLine(" 5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789");
            productosPuntoCinco.whereExecutionPuntoCinco();
            Console.ReadLine();
        }

        public static void puntoSeis()
        {
            CustomersLogic customerPuntoSeis = new CustomersLogic();
            Console.WriteLine("6. Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.");
            customerPuntoSeis.whereExecutionPuntoSeis();
            Console.ReadLine();
        }

        public static void puntoSiete()
        {
            CustomersLogic customerPuntoSiete = new CustomersLogic();
            Console.WriteLine("6. Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.");
            customerPuntoSiete.whereExecutionPuntoSiete();
            Console.ReadLine();
        }

        public static void puntoOcho()
        {
            CustomersLogic customerPuntoOcho = new CustomersLogic();
            Console.WriteLine("8.Query para devolver los primeros 3 Customers de Washington.");
            customerPuntoOcho.whereExecutionPuntoOcho();
            Console.ReadLine();

        }

        public static void puntoNueve()
        {
            ProductsLogic productsPuntoNueve = new ProductsLogic();
            Console.WriteLine("9. Query para devolver lista de productos ordenados por nombre.");
            productsPuntoNueve.whereExecutionPuntoNueve();
            Console.ReadLine();

        }

        public static void puntoDiez()
        {
            ProductsLogic productsPuntoDiez = new ProductsLogic();
            Console.WriteLine("10. Query para devolver lista de productos ordenados por unit in stock de mayor a menor.");
            productsPuntoDiez.whereExecutionPuntoDiez();
            Console.ReadLine();

        }

        public static void puntoOnce()
        {
            CategoriesLogic categoriesPuntoOnce = new CategoriesLogic();
            Console.WriteLine("11. Query para devolver las distintas categorías asociadas a los productos.");
            categoriesPuntoOnce.whereExecutionPuntoOnce();
            Console.ReadLine();

        }
        public static void puntoDoce()
        {
            ProductsLogic productsPuntoDoce = new ProductsLogic();
            Console.WriteLine("12. Query para devolver el primer elemento de una lista de productos.");
            productsPuntoDoce.whereExecutionPuntoDoce();
            Console.ReadLine();

        }


        public static void puntoTrece()
        {
            CustomersLogic customerPuntoTrece = new CustomersLogic();
            Console.WriteLine("8.Query para devolver los primeros 3 Customers de Washington.");
            customerPuntoTrece.whereExecutionPuntoTrece();
            Console.ReadLine();

        }



    }
}
