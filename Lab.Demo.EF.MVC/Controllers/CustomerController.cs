using Lab.Demo.EF.Entities;
using Lab.Demo.EF.Logic;
using Lab.Demo.EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Lab.Demo.EF.MVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        CustomersLogic logic = new CustomersLogic();
        public ActionResult Select()
        {
            List <Entities.Customers> customers = logic.GetAll();

            try
            {
                List<CustomerView> customerViews = customers.Select(s => new CustomerView
                {
                    id = s.CustomerID,
                    companyName = s.CompanyName,
                    contactName = s.ContactName,
                    contactTitle = s.ContactTitle,
                    address = s.Address,
                    city = s.City,
                    region = s.Region,
                    postalCode = s.PostalCode,
                    country = s.Country,
                    contactPhone = s.Phone,
                    fax = s.Fax
                }).ToList();
                return View(customerViews);
            }
            catch (System.Exception listar_customer_view)
            {
                
                throw listar_customer_view;
            }

        }

        public ActionResult Insert() 
        {


            return View();
        
        }

        public ActionResult InsertCorrecto()
        {
            return View();
        }
        public ActionResult UpdateCorrecto()
        {
            return View();
        }
        public ActionResult DeleteCorrecto()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(CustomerView customerView)
        {
            try
            {
                Customers customerEntity = new Customers
                {
                    CustomerID = customerIDGenerator(),
                    CompanyName = customerView.companyName,
                    ContactName = customerView.contactName,
                    ContactTitle = customerView.contactTitle,
                    Address = customerView.address,
                    City = customerView.city,
                    Region = customerView.region,
                    PostalCode = customerView.postalCode,
                    Country = customerView.country,
                    Phone = customerView.contactPhone,
                    Fax = customerView.fax


                };
                logic.Add(customerEntity);
                return RedirectToAction("InsertCorrecto", "Customer");


            }
            catch (ArgumentNullException)
            {
                return RedirectToAction("Index", "CustomerUpdateError", "Customer");
            }
            catch (NullReferenceException)
            {
                return RedirectToAction("Index", "DeleteUpdateError", "Customer");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error", "Customer");
            }
        }
        public ActionResult Delete()
        {


            return View();

        }

        [HttpPost]
        public ActionResult Delete(CustomerView customerView)
        {
            try
            {
                string deleteID = customerView.id;

                logic.deleteCustomer(deleteID);
                return RedirectToAction("DeleteCorrecto", "Customer");


            }
            catch (ArgumentNullException)
            {
                return RedirectToAction("DeleteCustomerError", "Error", "Customer");
            }
            catch (NullReferenceException)
            {
                return RedirectToAction("DeleteCustomerError", "Error", "Customer");
            }
            catch (System.Exception)
            {
                return RedirectToAction("DeleteCustomerError", "Error", "Customer");
            }
        }

        public ActionResult Update()
        {


            return View();

        }

        [HttpPost]
        public ActionResult Update(CustomerView customerView)
        {
            try
            {
                string customerID = customerView.id;
                string newName = customerView.contactName;

                logic.updateCustomer(customerID, newName);
                return RedirectToAction("UpdateCorrecto", "Customer");


            }
            catch (ArgumentNullException)
            {
                return RedirectToAction("CustomerUpdateError", "Error", "Customer");
            }
            catch (NullReferenceException)
            {
                return RedirectToAction("CustomerUpdateError", "Error", "Customer");
            }
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
    }
}