using Appshop.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appshop
{
    class OrderDetalesDb
    {
        public OrderDetales merre = new OrderDetales();
        public void AddOrderDetales(OrderDetales addo)
        {

            using (var conn = DbConnection.GetConnection())
            {

                using (var cmd = DbConnection.Command(conn, "dbo.AddOrdersdet", CommandType.StoredProcedure))
                {
                    DbConnection.AddParameter(cmd, "@ClientID", addo.ClientID);
                   
                    DbConnection.AddParameter(cmd, "@Shipping", addo.Shipping);
                    DbConnection.AddParameter(cmd, "@Taxvat", addo.Taxvat);
                    DbConnection.AddParameter(cmd, "@Total", addo.Total);
                   
                    cmd.ExecuteNonQuery();
                }

            }

        }

        public static OrderDetales SendID()
        {
            OrderDetales SendIdis = new OrderDetales();
            SqlConnection lidhe = new SqlConnection(DbConnection.sqllidhja);
            lidhe.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1  OrderDetalesID  FROM OrderDetales ORDER BY OrderDetalesID DESC", lidhe);
            Object temp1 = cmd.ExecuteScalar();
            SendIdis.OrderDetalesID = Convert.ToInt32(temp1);
            return SendIdis;


        }
    }
}
