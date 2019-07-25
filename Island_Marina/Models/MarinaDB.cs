using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Island_Marina.Models
{
    public class MarinaDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=localhost\SAITSQLEXPRESS;Initial Catalog=Marina;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }
    }
}