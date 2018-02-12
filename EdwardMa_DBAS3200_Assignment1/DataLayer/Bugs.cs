using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Bugs
    {
        //Get a list of all the bug
        public List<Bug> GetAllBugList() 
        {
            List<Bug> allBugList = new List<Bug>();

            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"getBug"; // stored procedure name
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read()) //store each line from procedure into the list
                    {
                        Bug b = new Bug();
                        b.Load(reader);
                        allBugList.Add(b);
                    }
                }
            }
            return allBugList;
        }
        
        //Get a list of all the filtered bug list
        public List<Bug> GetFilteredBugList(string p_AppName, string p_StatusCodeDesc) 
        {
            List<Bug> bugList = new List<Bug>();

            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"getBugList"; // stored procedure name
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter SQLP_AppName = new SqlParameter("p_AppName", System.Data.SqlDbType.NVarChar, 40);
                    SQLP_AppName.Value = p_AppName;
                    command.Parameters.Add(SQLP_AppName);

                    SqlParameter SQLP_StatusCodeDesc = new SqlParameter("p_StatusCodeDesc", System.Data.SqlDbType.NVarChar, 40);
                    SQLP_StatusCodeDesc.Value = p_StatusCodeDesc;
                    command.Parameters.Add(SQLP_StatusCodeDesc);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read()) //store each line from procedure into the list
                    {
                        Bug b = new Bug();
                        b.Load(reader);
                        bugList.Add(b);
                    }
                }
            }
            return bugList;
        }

        public List<Bug> BugDetailInfo(string p_BugDesc)
        {
            List<Bug> bugDetailInfoList = new List<Bug>();

            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"getBugDetails"; // stored procedure name
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter SQLp_BugDesc = new SqlParameter("p_BugDesc", System.Data.SqlDbType.NVarChar, 40);
                    SQLp_BugDesc.Value = p_BugDesc;
                    command.Parameters.Add(SQLp_BugDesc);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read()) //store each line from procedure into the list
                    {
                        Bug b = new Bug();
                        b.Load(reader);
                        bugDetailInfoList.Add(b);
                    }
                }
            }
            return bugDetailInfoList;
        }

        public void DeleteBug(string p_BugID)
        {
            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"deleteBug";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter SQLP_BugID = new SqlParameter("p_BugID", System.Data.SqlDbType.NVarChar, 80);
                    SQLP_BugID.Value = p_BugID;
                    command.Parameters.Add(SQLP_BugID);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertBug(string p_BugDate, string p_BugDetails, string p_BugDesc, string p_RepSteps, string p_FixDate)
        {
            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"insertBug";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter SQLp_BugDate = new SqlParameter("p_BugDate", System.Data.SqlDbType.DateTime);
                    SQLp_BugDate.Value = p_BugDate;
                    command.Parameters.Add(SQLp_BugDate);

                    SqlParameter SQLp_BugDetails = new SqlParameter("p_BugDetails", System.Data.SqlDbType.NVarChar, 40);
                    SQLp_BugDetails.Value = p_BugDetails;
                    command.Parameters.Add(SQLp_BugDetails);

                    SqlParameter SQLp_BugDesc = new SqlParameter("p_BugDesc", System.Data.SqlDbType.NVarChar, 40);
                    SQLp_BugDate.Value = p_BugDesc;
                    command.Parameters.Add(SQLp_BugDate);

                    SqlParameter SQLp_RepSteps = new SqlParameter("p_RepSteps", System.Data.SqlDbType.NVarChar, 40);
                    SQLp_RepSteps.Value = p_RepSteps;
                    command.Parameters.Add(SQLp_RepSteps);

                    SqlParameter SQLp_FixDate = new SqlParameter("p_FixDate", System.Data.SqlDbType.DateTime);
                    SQLp_FixDate.Value = p_FixDate;
                    command.Parameters.Add(SQLp_FixDate);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateBug(string p_BugDate, string p_BugDetails, string p_BugDesc, string p_RepSteps, string p_FixDate)
        {
            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"updateBug";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter SQLp_BugDate = new SqlParameter("p_BugDate", System.Data.SqlDbType.DateTime);
                    SQLp_BugDate.Value = p_BugDate;
                    command.Parameters.Add(SQLp_BugDate);

                    SqlParameter SQLp_BugDetails = new SqlParameter("p_BugDetails", System.Data.SqlDbType.NVarChar, 40);
                    SQLp_BugDetails.Value = p_BugDetails;
                    command.Parameters.Add(SQLp_BugDetails);

                    SqlParameter SQLp_BugDesc = new SqlParameter("p_BugDesc", System.Data.SqlDbType.NVarChar, 40);
                    SQLp_BugDate.Value = p_BugDesc;
                    command.Parameters.Add(SQLp_BugDate);

                    SqlParameter SQLp_RepSteps = new SqlParameter("p_RepSteps", System.Data.SqlDbType.NVarChar, 40);
                    SQLp_RepSteps.Value = p_RepSteps;
                    command.Parameters.Add(SQLp_RepSteps);

                    SqlParameter SQLp_FixDate = new SqlParameter("p_FixDate", System.Data.SqlDbType.DateTime);
                    SQLp_FixDate.Value = p_FixDate;
                    command.Parameters.Add(SQLp_FixDate);
                    command.ExecuteNonQuery();
                }
            }
        }

        public class Bug
        {
            public int BugID { get; set; }
            public DateTime BugDate { get; set; }
            public string BugDetails { get; set; }
            public string BugDesc { get; set; }
            public string RepSteps { get; set; }
            public DateTime FixDate { get; set; }
            public int StatusCodeID { get; set; }
            public void Load(SqlDataReader reader)
            {
                BugID = Int32.Parse(reader["BugID"].ToString());
                BugDate = DateTime.Parse(reader["BugDate"].ToString());
                BugDetails = reader["BugDetails"].ToString();
                BugDesc = reader["BugDesc"].ToString();
                RepSteps = reader["RepSteps"].ToString();
                FixDate = DateTime.Parse(reader["FixDate"].ToString());
                StatusCodeID = Int32.Parse(reader["StatusCodeID"].ToString());
            }

                //[BugID]      INT          IDENTITY (1, 1) NOT NULL,
                //[AppID]      INT          NOT NULL,
                //[UserID]     INT          NOT NULL,
                //[BugSignOff] INT          NULL,
                //[BugDate]    DATETIME     DEFAULT (getdate()) NOT NULL,
                //[BugDetails] NTEXT        NULL,
                //[BugDesc]    VARCHAR (40) NULL,
                //[RepSteps]   NTEXT        NULL,
                //[FixDate]    DATETIME     DEFAULT (getdate()) NULL,
        }
    }
}
