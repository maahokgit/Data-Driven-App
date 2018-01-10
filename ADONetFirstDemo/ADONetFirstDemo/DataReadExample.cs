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
        public void RunDemo()
        {
            string connectionString 
                = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\NSCCStudent\Desktop\Northwind.mdf';Integrated Security=True;Connect Timeout=30";
            
            //Establish Connection
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            //Create command with the connection
            SqlCommand cmd = new SqlCommand("SELECT * FROM products", conn);
            
            //Execute the command....reader because it is a select statement
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine("\t{0}\t{1}\t{2}", reader[0], reader[1], reader[2]);
            }
            conn.Close();

            //keep the console windows open until user enter any key.
            Console.ReadKey();
        }
    }
}
