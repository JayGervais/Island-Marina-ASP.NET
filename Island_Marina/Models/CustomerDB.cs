using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Island_Marina.Models
{
    public class CustomerDB
    {
        public void CreateAccount(string firstName, string lastName, string phone, string city, string email)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SAITSQLEXPRESS;Initial Catalog=Marina;Integrated Security=True");

            string addCustomerQuery = @"INSERT INTO Customer " +
                                        "(FirstName, LastName, Phone, City, Email) " +
                                        "VALUES (@firstName, @lastName, @phone, @city, @email)";

            SqlCommand sqlCommand = new SqlCommand(addCustomerQuery, con);
            sqlCommand.Parameters.AddWithValue("@firstName", firstName);
            sqlCommand.Parameters.AddWithValue("@lastName", lastName);
            sqlCommand.Parameters.AddWithValue("@phone", phone);
            sqlCommand.Parameters.AddWithValue("@city", city);
            sqlCommand.Parameters.AddWithValue("@email", email);
            con.Open();
            int k = sqlCommand.ExecuteNonQuery();

            con.Close();
        }
    }
}