using Appshop.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appshop
{
    class OrdersDB
    {
        public Orders merre = new Orders();
        public void AddOrders(Orders addor)
        {

            using (var conn = DbConnection.GetConnection())
            {

                using (var cmd = DbConnection.Command(conn, "dbo.AddOrders", CommandType.StoredProcedure))
                {
                    DbConnection.AddParameter(cmd, "@ClientID", addor.ClientID);
                    DbConnection.AddParameter(cmd, "@OrderDetalesID", addor.OrderDetalesID);
                    DbConnection.AddParameter(cmd, "@ProductID", addor.ProductID);
                    DbConnection.AddParameter(cmd, "@Quantity", addor.Quantity);
                    DbConnection.AddParameter(cmd, "@Total", addor.Total);
  
                 
                    cmd.ExecuteNonQuery();
                }

            }

        }
    }
}
