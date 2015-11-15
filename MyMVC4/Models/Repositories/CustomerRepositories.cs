
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebProxy;


namespace MyMVC4.Models.Repositories
{
    public class CustomerRepositories
    {
        public string GetCustomerData(string custId)
        {
            string result = new CustomerProxy("http://localhost:38237/", "").GetCustomerData(custId);
            return result;
           // return new CustomerProxy().GetCustomerData(custId);
           // return "";

           // string result = new OrderProxy(_coreApiAddress, "th").AdminCreateQutationOrSaleOrder(orderGuid, username);
        }
    }
}