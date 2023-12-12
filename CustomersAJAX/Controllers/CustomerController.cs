using CustomersAJAX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomersAJAX.Controllers
{
    public class CustomerController : Controller
    {
        Customer customer;
        List<Customer> customers;

        public CustomerController()
        {
            // get some data
            customers = new List<Customer>();
            customers.Add(new Customer(0, "Sherry", 37));
            customers.Add(new Customer(1, "Fin", 22));
            customers.Add(new Customer(2, "Isaac", 65));
            customers.Add(new Customer(3, "Josh", 42));
            customers.Add(new Customer(4, "Toby", 14));
            customers.Add(new Customer(5, "Theo", 82));
            customers.Add(new Customer(6, "Cameron", 41));
        }



        // GET: Customer
        public ActionResult Index()
        {
            Tuple<List<Customer>, Customer> tuple;
            tuple = new Tuple<List<Customer>, Customer>(customers, customers[0]);

            return View("Customer", tuple);
        }
    }
}