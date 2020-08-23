using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appshop.Clases
{
    class ProductsDb
    {
        
        public void AddProduct(Products addp)
        {

            using (var conn = DbConnection.GetConnection())
            {

                using (var cmd = DbConnection.Command(conn, "dbo.usp_Product", CommandType.StoredProcedure))
                {
                    DbConnection.AddParameter(cmd, "@ProductName", addp.ProductName);
                    DbConnection.AddParameter(cmd, "@Price", addp.Price);
                    DbConnection.AddParameter(cmd, "@Quantity", addp.Quantity);
                    DbConnection.AddParameter(cmd, "@Description", addp.Description);
                    DbConnection.AddParameter(cmd, "@insertby", Users.ID);
                    cmd.ExecuteNonQuery();
                }

            }

        }
        public static List<Products> ProductList(string search)
        {
            List<Products> pList = new List<Products>();
            var cnn = DbConnection.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            if (search != "")
            {
                cmd.CommandText = "select * from Product where ProductName like @search or Description like @search";
                cmd.Parameters.AddWithValue("@search", search);
            }
            else
                cmd.CommandText = "select * from Product";
            cmd.CommandType = CommandType.Text;
            cnn.Close();
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                var d = new Products();
                d.ProductID = Convert.ToInt32(dr["ProductID"]);
                d.ProductName = (dr["ProductName"].ToString());
                d.Price = Convert.ToInt32(dr["Price"]);
                d.Quantity = Convert.ToInt32(dr["Quantity"]);
                d.Description = dr["Description"].ToString();
                pList.Add(d);

            }
            cnn.Close();
            return pList;
        }
    }
}
