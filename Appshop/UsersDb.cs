using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appshop
{
    public class UsersDb
    {
        public void Login(Users Login)
        {
            try
            {
                using (var conn = DbConnection.GetConnection())
                {
                    using (var cmd = DbConnection.Command(conn, "dbo.Login", CommandType.StoredProcedure))
                    {
                        DbConnection.AddParameter(cmd, "@Username", Login.Username);
                        DbConnection.AddParameter(cmd, "@Password", Login.Password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            Users result = null;
                            if (reader.Read())
                            {
                                result = ToObject(reader);
                            }

                           
                        }
                    }
                }
            }
            catch (Exception e)
            {

               
            }

        }
     
        public Users ToObject(SqlDataReader reader)
        {
            Users user = new Users();
            user.ID = int.Parse(reader["UserID"].ToString());
            user.Username = reader["Username"].ToString();
            //if (reader["EmployeeID"] != DBNull.Value)
            //    user.ID = int.Parse(reader["EmployeeID"].ToString());
            //user.UserRoleID = int.Parse(reader["RoliID"].ToString());
            //if (reader["LastLoginDate"] != DBNull.Value)
            //user.LastLoginDate = (DateTime)reader["LastLoginDate"];

            //if (reader["LastPasswordChangeDate"] != DBNull.Value)
            //    user.LastPasswordChangeDate = (DateTime)reader["LastPasswordChangeDate"];

            //if (reader["IsPasswordChanged"] != DBNull.Value)
            //    user.IsPasswordChanged = reader["IsPasswordChanged"].ToString() == "1";

            //user.insertBy = reader["InsertBy"].ToString();
            //user.InsertDate = (DateTime)reader["InsertDate"];
            //update

            return user;

        }
    }
}
