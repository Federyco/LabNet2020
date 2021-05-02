using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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
        public static string customerID;
        public static string companyName;
        public static string contactName;
        public static string contactTitle;
        public static string address;
        public static string city;
        public static string region;
        public static string postalCode;
        public static string country;
        public static string phone;
        public static string fax;
        public static bool validationOne = true;

        static void Main(string[] args)
        {
            string ingreso = " ";
            bool seleccion = false;
            while (validationOne == true)
            {
                Console.WriteLine("Ejercicio 4 - Entities Framework");
                Console.WriteLine("Ingrese 1 - Para Agregar Un Nuevo Cliente");
                Console.WriteLine("Ingrese 2 - Para Eliminar Un Cliente");
                Console.WriteLine("Ingrese 3 - Para Actualizar Un Cliente");
                Console.WriteLine("Ingrese 4 - Para Listar Los Clientes Existentes");
                Console.WriteLine("Ingrese 5 - Para Ingresar a la solución del punto 4");
                Console.WriteLine("Ingrese 6 - Para Salir");

                ingreso = Console.ReadLine();
                // el ingreso fue un número?
                try
                {
                    seleccion = emIAnInteger(ingreso);
                }
                catch (CustomMyExceptions myException)
                {

                    throw myException;
                }


                // si lo fue continua el programa
                if (seleccion == true)
                {
                    if (ingreso == "1")
                    {
                        Console.WriteLine("Los ID de cliente se generan automáticamente");
                        customerID = customerIDGenerator();
                        Console.WriteLine($"Su nuevo ID de Cliente es: {customerID}");
                        Console.WriteLine("Compañia: ");
                        companyName = Console.ReadLine();
                        Console.WriteLine("Contacto: ");
                        contactName = Console.ReadLine();
                        Console.WriteLine("Sr/Srs/Sra/Sras/Mr/Ms");
                        contactTitle = Console.ReadLine();
                        Console.WriteLine("Dirección: ");
                        address = Console.ReadLine();
                        Console.WriteLine("Ciudad: ");
                        city = Console.ReadLine();
                        Console.WriteLine("Región o Localidad: ");
                        region = Console.ReadLine();
                        Console.WriteLine("Código Postal: ");
                        postalCode = Console.ReadLine();
                        Console.WriteLine("País: ");
                        country = Console.ReadLine();
                        Console.WriteLine("Teléfono: ");
                        phone = Console.ReadLine();
                        Console.WriteLine("Fax: ");
                        fax = Console.ReadLine();

                        NewCustomerApproaches(customerID, companyName, contactName, contactTitle, address, city, region, postalCode, country, phone, fax);
                        Console.ReadLine();
                        validationOne = false;
                    }
                    if (ingreso == "2")
                    {
                        //DELETE
                        DeleteCustomerFromTable();
                        Console.ReadLine();
                    }
                    if (ingreso == "3")
                    {
                        // UPDATE
                        UpdateCustomer();
                        Console.ReadLine();
                    }
                    if (ingreso == "4")
                    {
                        // SELECT
                        SelectAllCustomers();
                        Console.ReadLine();
                    }
                    if (ingreso == "5")
                    {
                        puntoCuatro();
                        Console.ReadLine();
                    }
                    if (ingreso == "6")
                    {
                        Console.WriteLine("Saliendo del Sistema");
                        validationOne = false;
                    }
                }//Si no lo fue, continua pidiendo que seleccione una opción
            }
        }
        // add new customer
        public static void NewCustomerApproaches(string customerID, string companyName, string contactName, string contactTitle, string address,
                                                 string city, string region, string postalCode, string country, string phone, string fax)

        {
            CustomersLogic customerLogic = new CustomersLogic();
            try
            {
                customerLogic.Add(new Customers
                {
                    CustomerID = customerID,
                    ContactName = contactName,
                    CompanyName = companyName,
                    ContactTitle = contactTitle,
                    Address = address,
                    City = city,
                    Region = region,
                    PostalCode = postalCode,
                    Country = country,
                    Phone = phone,
                    Fax = fax
                });
            }
            catch (DbEntityValidationException ex)
            {

                Console.WriteLine("\n", ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (DbUpdateException db_update)
            {

                Console.WriteLine($"\nMensaje :  {db_update.Message} ");
                Console.WriteLine($"\nTracer : {db_update.StackTrace}");
            }
            /* catch (CustomMyExceptions exception)
             {
                 Console.WriteLine(exception.Message);
                 throw new CustomMyExceptions("Probando las exceptions");
             }*/
        }
        public static string customerIDGenerator()
        {
            string new_Customer_Id = "";
            string acumulador = "";
            int randomHolder = 0;
            Random randomNumber = new Random();


            List<string> caracteres_random = new List<string>();
            caracteres_random.Add("A");
            caracteres_random.Add("B");
            caracteres_random.Add("C");
            caracteres_random.Add("D");
            caracteres_random.Add("E");
            caracteres_random.Add("F");
            caracteres_random.Add("G");
            caracteres_random.Add("H");
            caracteres_random.Add("I");
            caracteres_random.Add("J");
            caracteres_random.Add("K");
            caracteres_random.Add("M");
            caracteres_random.Add("N");
            caracteres_random.Add("O");
            caracteres_random.Add("P");
            caracteres_random.Add("Q");
            caracteres_random.Add("R");
            caracteres_random.Add("S");
            caracteres_random.Add("T");
            caracteres_random.Add("U");
            caracteres_random.Add("V");
            caracteres_random.Add("W");
            caracteres_random.Add("X");
            caracteres_random.Add("Y");
            caracteres_random.Add("Z");

            for (int i = 1; i <= 5; i++)
            {
                randomHolder = randomNumber.Next(0, 24);
                acumulador = caracteres_random[randomHolder];
                new_Customer_Id += acumulador;
            }
            return new_Customer_Id.ToUpper();
        }

        public static void DeleteCustomerFromTable()
        {
            CustomersLogic customerLogic = new CustomersLogic();
            string IdCliente;
            try
            {

                Console.WriteLine("Ingrese el ID del Cliente que desea Eliminar");
                IdCliente = Console.ReadLine();
                if (AlreadyInDatabase(IdCliente) == true)
                {
                    customerLogic.deleteCustomer(IdCliente);
                }
                /*else 
                {
                    throw new CustomMyExceptions("El Usuario no existe en la data base");
                }*/
            }
            catch (DbEntityValidationException ex)
            {

                Console.WriteLine("\n", ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        public static void UpdateCustomer()
        {
            CustomersLogic customerLogic = new CustomersLogic();
            string IdCliente;
            string newContactName;
            Console.WriteLine("Ingrese el ID del Cliente que desea Actualizar");
            IdCliente = Console.ReadLine();
            Console.WriteLine("Ingrese el Nuevo Nombre de contacto");
            newContactName = Console.ReadLine();
            try
            {
                customerLogic.updateCustomer(IdCliente, newContactName);
            }
            catch (DbEntityValidationException ex)
            {

                Console.WriteLine("\n", ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

        }

        public static void SelectAllCustomers()
        {
            CustomersLogic customerLogic = new CustomersLogic();
            foreach (var item in customerLogic.GetAll())
            {
                Console.WriteLine($"\n{item.CustomerID} - {item.ContactName} - {item.CompanyName} - {item.ContactTitle} - {item.Address} - {item.City} - {item.Region} - {item.PostalCode} - {item.Country} - {item.Phone} - {item.Fax}");
            }

        }

        public static bool emIAnInteger(string input)
        {
            int number = 0;
            try
            {
                return int.TryParse(input, out number);
            }

            catch (Exception ex)
            {
                throw ex;
            }


        }

        public static void puntoCuatro()
        {
            //realizo 2 consultas a diferentes Entidades
            ShippersLogic shipperLogic = new ShippersLogic();
            Console.WriteLine("Select aplicado a la tabla Shippers");
            foreach (var item1 in shipperLogic.GetAll())
            {

                Console.WriteLine($"\nShipper ID: {item1.ShipperID} ** Company Name: {item1.CompanyName} ** Phone: {item1.Phone}");
                Console.WriteLine($"********************************************************************************************");
            }

            TerritoriesLogic territoriesLogic = new TerritoriesLogic();
            Console.WriteLine("Select aplicado a la tabla Territory");
            foreach (var item2 in territoriesLogic.GetAll())
            {
                Console.WriteLine($"\nTerritory ID: {item2.TerritoryID} ** Territory Description: {item2.TerritoryDescription} ** Region: {item2.RegionID}");
                Console.WriteLine($"**********************************************************************************************************************");
            }

        }

        public static bool AlreadyInDatabase(string input)
        {
            CustomersLogic customerLogic = new CustomersLogic();
            if (customerLogic.SearchForExistence(input) == false)
            {
                return false;
            }
            else 
            {
                return true;
            }
        
        }
    }
}
