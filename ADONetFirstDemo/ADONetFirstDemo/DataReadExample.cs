using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ADONetFirstDemo
{
    class DataReadExample
    {
        public void RunDemo()
        {
            string connectionString 
                = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\NSCCStudent\Desktop\Northwind.mdf';Integrated Security=True;Connect Timeout=30";

            //Establish Connection
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                //Create command with the connection
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM products", conn))
                {
                    //Execute the command....reader because it is a select statement
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("\t{0}\t{1}\t{2}", reader["ProductName"], reader["UnitPrice"], reader["UnitsInStock"]);

                            Thread.Sleep(250);
                        }
                    }
                }
            }

            //JAVA EQUIVALENT 
            //try
            //{
            //    //open a db connection
            //}
            //catch(Exception e)
            //{
            //    //handle any errors
            //}
            //finally
            //{
            //    //close and dispose of the object
            //}
            //keep the console windows open until user enter any key.
            Console.ReadKey();
        }
    }
}
