using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appshop.Clases
{
    public class ClientList
    {
        public static List<Clients> Clientlists(string search )
        {
            List<Clients> Clist = new List<Clients>();
            var cnn = DbConnection.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            if(search != "")
            {
                cmd.CommandText = "select * from Clients where Name like @search or surname like @search or City like @search";
                cmd.Parameters.AddWithValue("@search", search);
            }
            else
            cmd.CommandText = "select * from Clients";
            cmd.CommandType = CommandType.Text;
            cnn.Close();
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                var d = new Clients();
                d.ClientID = Convert.ToInt32(dr["ClientID"]);
                d.Name = (dr["Name"].ToString());
                d.Surname = dr["Surname"].ToString();
                d.Addres = dr["Address"].ToString();
                d.City = dr["City"].ToString();
                d.Email = dr["Email"].ToString();
                d.Description = dr["Description"].ToString();
                d.CompanyName = dr["CompanyName"].ToString();
                d.CompanyNo = (dr["CompanyNo"].ToString());
                d.Phone = (dr["Phone"].ToString());
                Clist.Add(d);

            }
            cnn.Close();
            return Clist;
        }
        public static string Delete(int d)
        {
            var cnn = DbConnection.GetConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            cmd.CommandText = "delete from Clients where ClientID = @ClientID";
            cmd.Parameters.AddWithValue("@ClientID", d);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteScalar();
            cnn.Close();
            cnn.Open();
            return null;
        }
    }
}
