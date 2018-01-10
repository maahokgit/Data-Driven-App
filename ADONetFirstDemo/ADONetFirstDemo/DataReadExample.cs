using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONetFirstDemo
{
    class DataReadExample
    {
        void RunDemo()
        {

            string connectionString = "Data Source=(local);Initial Catalog=Northwind;Integrated Security=SSPI";
            //Establish Connection
            SqlConnection conn = new SqlConnection(connectionString);
            //Create command with the connection
            SqlCommand cmd = new SqlCommand("SELECT * FROM products", conn);
            //Execute the command....reader because it is a select statement
            SqlDataReader reader = cmd.ExecuteReader();
            //break point https://youtu.be/d7tKTRyZf_E?list=PLidBpabdCX9A2UaXbbakmYwl5JHO2-Yne&t=5587
        }
    }
}
