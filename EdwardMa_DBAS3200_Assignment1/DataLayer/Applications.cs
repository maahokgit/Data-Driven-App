using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer
{
    class Applications
    {
        public List<Application> GetAppList() //Get a list of all the application
        {
            List<Application> applications = new List<Application>();

            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"getApp"; // stored procedure name
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read()) //store each line from procedure into the list
                    {
                        Application app = new Application();
                        app.Load(reader);
                        applications.Add(app);
                    }
                }
            }

            return applications;
        }

        public class Application
        {
            public int AppID { get; set; }
            public string AppName { get; set; }
            public string AppVersion { get; set; }
            public string AppDesc { get; set; }

            public void Load(SqlDataReader reader)
            {
                AppID = Int32.Parse(reader["AppID"].ToString());
                AppName = reader["AppName"].ToString();
                AppVersion = reader["LastName"].ToString();
                AppDesc = reader["Name"].ToString();
            }
        }
    }
}
