using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Status
    {
        public List<statusList> GetStatus() //Get a list of all the application
        {
            List<statusList> status = new List<statusList>();

            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"getStatus"; // stored procedure name
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read()) //store each line from procedure into the list
                    {
                        statusList s = new statusList();
                        s.Load(reader);
                        status.Add(s);
                    }
                }
            }
            return status;
        }

        public class statusList
        {
            public int StatusCodeID { get; set; }
            public string StatusCodeDesc { get; set; }

            public void Load(SqlDataReader reader)
            {
                StatusCodeID = Int32.Parse(reader["StatusCodeID"].ToString());
                StatusCodeDesc = reader["StatusCodeDesc"].ToString();
            }
        }
    }
}
