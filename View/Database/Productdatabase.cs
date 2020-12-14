using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using View.Classess;
using View.Utils;

namespace View.Database
{
    public class Productdatabase
    {
        public static Product GetProductByID(string id)
        {
            Product pr = new Product();
            string sqlQuery = $"select * from tb_product where _id_product=@id;";
            try
            {
                Connection.OpenConnection();
                Connection.cmd.CommandType = CommandType.Text;
                Connection.cmd.CommandText = sqlQuery;
                Connection.cmd.Parameters.Clear();
                Connection.cmd.Parameters.AddWithValue("@id", id);
                Connection.rd = Connection.cmd.ExecuteReader();
                if (Connection.rd.Read())
                {
                    
                    pr.Id_product = Connection.rd.GetValue(0).ToString();
                    pr.Name_product = Connection.rd.GetValue(1).ToString();
                    pr.Price_product = Double.Parse(Connection.rd.GetValue(2).ToString());
                    pr.Size_product = Connection.rd.GetValue(3).ToString();
                    pr.Amount_product = Connection.rd.GetInt32(4);        
                    pr.Image_product = Helpers.ConvertByteToImageBitmap((byte[])Connection.rd.GetValue(5));
                    return pr;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error get Product " + e.Message);
                return pr;
            }
            finally
            {
                Connection.CloseConnection();
            }
            return pr;
        }
    }
}
