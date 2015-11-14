using DataCustomer_Api.Models;
using DataCustomer_Api.Models.RepositoriesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataCustomer_Api.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public string Get(string custId)
        {
            CustomerRepositories customerRepo = new CustomerRepositories();
            string customer = customerRepo.GetCustomer(custId);
            return customer;
        }

    }
}