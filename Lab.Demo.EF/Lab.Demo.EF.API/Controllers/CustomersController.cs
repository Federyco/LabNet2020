using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Lab.Demo.EF.Data;
using Lab.Demo.EF.Entities;
using Lab.Demo.EF.Logic;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Web.Http.Cors;
using Lab.Demo.EF.API.Models;

namespace Lab.Demo.EF.API.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers:"*", methods:"*")]
    public class CustomersController : ApiController
    {
        
        private CustomersLogic logic = new CustomersLogic();

        // GET: api/Customers
        public List<CustomerView> GetCustomers()
        {
            List<Entities.Customers> customers = logic.GetAll();
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

            return customerViews;

        }

        // GET: api/Customers/5
        [ResponseType(typeof(CustomerView))]
        public IHttpActionResult GetCustomers(string id)
        {
        
            if (logic.SearchForExistence(id) == true) {
                return Ok(id);
            }
            else {
                return NotFound();
            }
        }

        // PUT: api/Customers/5
        [ResponseType(typeof(CustomerView))]
        public IHttpActionResult PutCustomers(CustomerView customerView)
        {
            bool getID = logic.SearchForExistence(customerView.id);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (getID == false)
            {
                return NotFound();
            }
            else
            {
                try
                {
                    Customers customerEntity = new Customers
                    {
                        CustomerID = customerView.id,
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

                    logic.updateCustomer(customerEntity);
                    return Ok(customerEntity);
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }
            }
        }
        // POST: api/Customers
        [ResponseType(typeof(CustomerView))]
        public IHttpActionResult PostCustomers(CustomerView customerView)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Customers customerEntity = new Customers
            {
                CustomerID = customerView.id,
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
            try
            {
                logic.Add(customerEntity);
                return Ok(customerView);
            }
            catch (Exception)
            {
                return NotFound();
                throw;
            }
        
        }
        // DELETE: api/Customers/5
        [ResponseType(typeof(CustomerView))]
        public IHttpActionResult DeleteCustomers(string id)
        {
            try
            {
                if (logic.SearchForExistence(id) == true)
                {
                    logic.deleteCustomer(id);
                    return Ok(id);
                }
                else 
                {
                    return NotFound();
                }      
                }
                catch (Exception)
                {

                    throw;
                }
        }
        protected override void Dispose(bool disposing)
        {
            disposing = true;
        }
        private bool CustomersExists(string id)
        {
            return logic.SearchForExistence(id);
        }
    }
}