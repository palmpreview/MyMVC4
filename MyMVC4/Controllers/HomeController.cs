using MyMVC4.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVC4.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            CustomerRepositories customerRepo = new CustomerRepositories();
            string custId = "12345";
            string result = customerRepo.GetCustomerData(custId);
            return View();
        }

    }
}
