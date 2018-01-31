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

        /// <summary>
        /// Delete an Application from DB using the name of Application
        /// </summary>
        /// <param name="appName"></param>
        public void DeleteApp(string appName) //delete an application from DB
        {
            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"deleteApp";
                    command.CommandType = System.Data.CommandType.StoredProcedure;


                    SqlParameter p_appName = new SqlParameter("p_AppName", System.Data.SqlDbType.NVarChar, 40);
                    p_appName.Value = appName;

                    command.Parameters.Add(p_appName);

                    command.ExecuteNonQuery();

                }
            }
        }


        /// <summary>
        /// Insert a new Application, using Application Name, Version and Desc
        /// </summary>
        /// <param name="p_appName"></param>
        /// <param name="p_appVersion"></param>
        /// <param name="p_appDesc"></param>
        public void InsertApp(string p_appName, string p_appVersion, string p_appDesc)
        {
            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"insertApp";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter SQLP_AppName = new SqlParameter("p_AppName", System.Data.SqlDbType.NVarChar, 40);
                    SQLP_AppName.Value = p_appName;
                    command.Parameters.Add(SQLP_AppName);

                    SqlParameter SQLP_AppVersion = new SqlParameter("p_AppVersion", System.Data.SqlDbType.NVarChar, 40);
                    SQLP_AppVersion.Value = p_appVersion;
                    command.Parameters.Add(SQLP_AppVersion);

                    //used for concurrency check (manual)
                    SqlParameter SQLP_AppDesc = new SqlParameter("p_AppDesc", System.Data.SqlDbType.NVarChar, 255);
                    SQLP_AppDesc.Value = p_appDesc;
                    command.Parameters.Add(SQLP_AppDesc);

                    command.ExecuteNonQuery();

                }
            }
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
