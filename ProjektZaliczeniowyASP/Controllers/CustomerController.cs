using ProjektZaliczeniowyASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjektZaliczeniowyASP.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {

            CustomerList ListOfCustomers = new CustomerList()
            {
                CustomerData = {new Customer() {Id = 1, FirstName = "Maciej", LastName = "Bartczak"},
                                new Customer() {Id = 2, FirstName = "Joanna", LastName = "Bartczak"}}
            };


            return View(ListOfCustomers);
        }
    }
}