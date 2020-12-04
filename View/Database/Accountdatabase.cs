using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Database
{
    public class Accountdatabase
    {
        //Insert Account To Database
        public static bool insert(string phone, string password, int permisstion)
        {
            try
            {
                string sqlQuery = "insert into ACCOUNT values(@Phone,@Password,@Permission);";

                Connection.OpenConnection();
                Connection.cmd.CommandType = System.Data.CommandType.Text;
                Connection.cmd.CommandText = sqlQuery;

                Connection.cmd.Parameters.Clear();
                Connection.cmd.Parameters.AddWithValue("@Phone", phone);
                Connection.cmd.Parameters.AddWithValue("@Password", password);
                Connection.cmd.Parameters.AddWithValue("@Permission", permisstion);

                Connection.cmd.ExecuteScalar();
                return true;

            }
            catch(Exception e)
            {
                return false;
            }
            finally
            {
                Connection.CloseConnection();
            }
           
        }
    }
}
