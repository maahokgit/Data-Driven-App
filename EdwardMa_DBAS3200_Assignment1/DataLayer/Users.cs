using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class Users
    {
        public List<User> GetUserList() //Get a list of all the application
        {
            List<User> userList = new List<User>();

            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"getUser"; // stored procedure name
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read()) //store each line from procedure into the list
                    {
                        User u = new User();
                        u.Load(reader);
                        userList.Add(u);
                    }
                }
            }
            return userList;
        }

        public void ConfirmUser(int p_userID) //need to be fix...probably!
        {
            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"confirmUser";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter SQLP_userID = new SqlParameter("p_UserID", System.Data.SqlDbType.NVarChar, 40);
                    SQLP_userID.Value = p_userID;

                    command.Parameters.Add(SQLP_userID);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteUser(string p_userName)
        {
            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"deleteUser";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter SQLP_userName = new SqlParameter("p_UserName", System.Data.SqlDbType.NVarChar, 80);
                    SQLP_userName.Value = p_userName;
                    command.Parameters.Add(SQLP_userName);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertUser(string p_userName, string p_userEmail, string p_userTel)
        {
            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"insertUser";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter SQLP_userName = new SqlParameter("p_UserName", System.Data.SqlDbType.NVarChar, 80);
                    SQLP_userName.Value = p_userName;
                    command.Parameters.Add(SQLP_userName);

                    SqlParameter SQLP_userEmail = new SqlParameter("p_UserEmail", System.Data.SqlDbType.NVarChar, 80);
                    SQLP_userEmail.Value = p_userEmail;
                    command.Parameters.Add(SQLP_userEmail);

                    SqlParameter SQLP_userTel = new SqlParameter("p_UserTel", System.Data.SqlDbType.NVarChar, 80);
                    SQLP_userTel.Value = p_userTel;
                    command.Parameters.Add(SQLP_userTel);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateUser(string p_userName, string p_userEmail, string p_userTel)
        {
            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"updateUser";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter SQLP_userName = new SqlParameter("p_UserName", System.Data.SqlDbType.NVarChar, 80);
                    SQLP_userName.Value = p_userName;
                    command.Parameters.Add(SQLP_userName);

                    SqlParameter SQLP_userEmail = new SqlParameter("p_UserEmail", System.Data.SqlDbType.NVarChar, 80);
                    SQLP_userEmail.Value = p_userEmail;
                    command.Parameters.Add(SQLP_userEmail);

                    SqlParameter SQLP_userTel = new SqlParameter("p_UserTel", System.Data.SqlDbType.NVarChar, 80);
                    SQLP_userTel.Value = p_userTel;
                    command.Parameters.Add(SQLP_userTel);

                    command.ExecuteNonQuery();
                }
            }
        }

        public class User
        {
            public int UserID
            {
                get;
                set;
            }

            public string UserName
            {
                get;
                set;
            }

            public string UserEmail
            {
                get;
                set;
            }

            public string UserTel
            {
                get;
                set;
            }

            public void Load(SqlDataReader reader)
            {
                UserID = Int32.Parse(reader["UserId"].ToString());
                UserName = reader["UserName"].ToString();
                UserEmail = reader["UserEmail"].ToString();
                UserTel = reader["UserTel"].ToString();
            }
        }
    }
}
