using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace View.Database
{
    class Clientdatabase
    {

        public static bool UpdateToClient(string phone, string name, string adress)
        {
            try
            {
                string sqlQuery = "update client set Name_Client = @_name_client, adress = @_adress_client where Phone_Number = @_phone;";
                Connection.OpenConnection();
                Connection.cmd.CommandType = System.Data.CommandType.Text;
                Connection.cmd.CommandText = sqlQuery;

                Connection.cmd.Parameters.Clear();
                Connection.cmd.Parameters.AddWithValue("@Name_Client", name);
                Connection.cmd.Parameters.AddWithValue("@Adress_Client", adress);
                Connection.cmd.Parameters.AddWithValue("@Phone", phone);

                Connection.cmd.ExecuteScalar();

                MessageBox.Show("Update profile successfully!");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("update to client: " + e.Message);
                return false;
            }
            finally
            {
                Connection.CloseConnection();
            }

        }

        public static bool InsertToClient(string phone, string name, string adress)
        {
            try
            {
                string sqlQuery = "insert into client Values(@_name_client,@_adress_client,@_phone_number);";
                Connection.OpenConnection();
                Connection.cmd.CommandType = System.Data.CommandType.Text;
                Connection.cmd.CommandText = sqlQuery;

                Connection.cmd.Parameters.Clear();
                Connection.cmd.Parameters.AddWithValue("@Name_Client", name);
                Connection.cmd.Parameters.AddWithValue("@Adress_Client", adress);
                Connection.cmd.Parameters.AddWithValue("@Phone", phone);

                Connection.cmd.ExecuteScalar();


                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Insert to client: " + e.Message);

                return false;
            }
            finally
            {
                Connection.CloseConnection();
            }

        }

    }
}
