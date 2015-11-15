using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataCustomer_Api.Models.RepositoriesData
{
    public class CustomerRepositories
    {
        public string GetCustomer(string custId)
        {
            //Customer customer = new Customer();
            //customer.CustId = custId;
            //customer.UserName = "TestSystem";
            string result = "TestSystem";
            return result;
        }

        //public OrderData LoadOrderByGUID(string guid)
        //{
        //    OrderData order = new OrderData();
        //    using (SqlConnection connection = new SqlConnection(ConnectionString))
        //    {
        //        connection.Open();
        //        using (SqlCommand command = connection.CreateCommand())
        //        {
        //            command.CommandText = @"select OrderID from TBOrder Where GUID = @GUID";
        //            command.Parameters.AddWithValue("@GUID", guid);
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    string orderId = (string)reader["OrderID"];
        //                    order = LoadOrder(orderId);
        //                }
        //            }
        //        }
        //    }
        //    return order;
        //}
    }
}