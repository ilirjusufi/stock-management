using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appshop.Clases
{
    class StatisticesDb
    {
        public static Statistices GetStatistices()
        {
            Statistices SendIdis = new Statistices();
            SqlConnection lidhe = new SqlConnection(DbConnection.sqllidhja);
            lidhe.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from Orders", lidhe);
            SqlCommand cmd1 = new SqlCommand("select count(*) from Clients", lidhe);
            SqlCommand cmd2 = new SqlCommand("select count(*) from Product", lidhe);
            SqlCommand cmd3 = new SqlCommand("select sum(Total) from OrderDetales", lidhe);
            Object temp = cmd.ExecuteScalar();
            Object temp1 = cmd1.ExecuteScalar();
            Object temp2 = cmd2.ExecuteScalar();
            Object temp3 = cmd3.ExecuteScalar();
            SendIdis.TotalOrders = Convert.ToInt32(temp);
            SendIdis.TotalClients = Convert.ToInt32(temp1);
            SendIdis.TotalProducts = Convert.ToInt32(temp2);
            SendIdis.TotalSales = Convert.ToInt32(temp3);
            return SendIdis;


        }
    }
}
