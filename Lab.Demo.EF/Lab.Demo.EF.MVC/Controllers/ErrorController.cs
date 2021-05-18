using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Demo.EF.MVC.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult CustomerUpdateError()
        {
            return View();
        }
        public ActionResult newCustomerError()
        {
            return View();
        }
        public ActionResult DeleteCustomerError()
        {
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }
}
}