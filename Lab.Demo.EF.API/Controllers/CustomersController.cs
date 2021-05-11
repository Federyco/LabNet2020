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

namespace Lab.Demo.EF.API.Controllers
{
    public class CustomersController : ApiController
    {
        
        private CustomersLogic logic = new CustomersLogic();

        // GET: api/Customers
        public List<Customers> GetCustomers()
        {
            return logic.GetAll();
        }

        // GET: api/Customers/5
        [ResponseType(typeof(Customers))]
        public IHttpActionResult GetCustomers(string id)
        {
            Customers customers = logic.getOneCustomer(id);
            if (customers == null)
            {
                return NotFound();
            }

            return Ok(customers);
        }

        // PUT: api/Customers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCustomers(Customers customers)
        {
            string getID = customers.CustomerID;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (getID != customers.CustomerID)
            {
                return BadRequest();
            }
            try
            {
                logic.Add(customers);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomersExists(getID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return StatusCode(HttpStatusCode.NoContent);
        }
        // POST: api/Customers
        [ResponseType(typeof(Customers))]
        public IHttpActionResult PostCustomers(Customers customers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                logic.Add(customers);
            }
            catch (DbUpdateException)
            {
                if (CustomersExists(customers.CustomerID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }
            return CreatedAtRoute("DefaultApi", new { id = customers.CustomerID }, customers);
        }
        // DELETE: api/Customers/5
        [ResponseType(typeof(Customers))]
        public IHttpActionResult DeleteCustomers(string id)
        {
            Customers customers = logic.getOneCustomer(id);
            if (customers == null)
            {
                return NotFound();
            }
            try
            {
                logic.deleteCustomer(id);
                return Ok(customers);

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