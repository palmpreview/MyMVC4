using ApiHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProxy
{
    public class CustomerProxy : BaseProxy
    {
        public CustomerProxy(string baseUri, string locale) : base(baseUri, locale) { }
        public string GetCustomerData(string custId)
        {
            //string result = new CustomerProxy().GetCustomer(custId);
            //return result;
            return ProcessRequest<string>(CreateRequest("GET", "/api/GetCustomer?custId="+custId));
            //return "";

            //try
            //{
            //    return ProcessRequest<string>(CreateRequest("POST", "/api/B2COrderAdmin"), new { orderguid, username });
            //}
            //catch (Exception ex)
            //{
            //    return "false/" + ex.Message;
            //}

            //try
            //{
            //    return ProcessRequest<bool>(CreateRequest("GET", "/api/B2COrderAdmin/" + orderguid));
            //}
            //catch (Exception)
            //{
            //    return false;
            //}

        }
    }
}