using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appshop.Clases
{
    class ClientsDb
    {
        public Clients merre = new Clients();
        public void AddClients(Clients addC)
        {

            using (var conn = DbConnection.GetConnection())
            {

                using (var cmd = DbConnection.Command(conn, "dbo.usp_ClientsR", CommandType.StoredProcedure))
                {
                    DbConnection.AddParameter(cmd, "@Name", addC.Name);
                    DbConnection.AddParameter(cmd, "@Surname", addC.Surname);
                    DbConnection.AddParameter(cmd, "@Addres", addC.Addres);
                    DbConnection.AddParameter(cmd, "@City", addC.City);
                    DbConnection.AddParameter(cmd, "@email", addC.Email);
                    DbConnection.AddParameter(cmd, "@Description", addC.Description);
                    DbConnection.AddParameter(cmd, "@CompanyName", addC.CompanyName);
                    DbConnection.AddParameter(cmd, "@CompanyNo", addC.CompanyNo);
                    DbConnection.AddParameter(cmd, "@Phone", addC.Phone);
                    DbConnection.AddParameter(cmd, "@insertby", Users.ID);
                    cmd.ExecuteNonQuery();
                }

            }

        }
        public void EditClients(Clients addC)
        {

            using (var conn = DbConnection.GetConnection())
            {

                using (var cmd = DbConnection.Command(conn, "dbo.Shop_editoklient", CommandType.StoredProcedure))
                {
                    DbConnection.AddParameter(cmd, "@ClientID", addC.ClientID);
                    DbConnection.AddParameter(cmd, "@Name", addC.Name);
                    DbConnection.AddParameter(cmd, "@Surname", addC.Surname);
                    DbConnection.AddParameter(cmd, "@Addres", addC.Addres);
                    DbConnection.AddParameter(cmd, "@companyname", addC.CompanyName);
                    DbConnection.AddParameter(cmd, "@companyNo", addC.CompanyNo);
                    DbConnection.AddParameter(cmd, "@phone", addC.Phone);
                    DbConnection.AddParameter(cmd, "@City", addC.City);
                    DbConnection.AddParameter(cmd, "@email", addC.Email);
                    DbConnection.AddParameter(cmd, "@Description", addC.Description);
                    DbConnection.AddParameter(cmd, "@insertby", Users.ID);
                    cmd.ExecuteNonQuery();
                }

            }

        }

    }
}