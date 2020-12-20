using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using View.Classess;


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

        public static bool InsertToClient(string phone, string name, string Address)
        {
            try
            {
                string sqlQuery = "insert into tb_client Values(@Name_Client,@Phone,@Address);";
                Connection.OpenConnection();
                Connection.cmd.CommandType = System.Data.CommandType.Text;
                Connection.cmd.CommandText = sqlQuery;

                Connection.cmd.Parameters.Clear();
                Connection.cmd.Parameters.AddWithValue("@Name_Client", name);
                Connection.cmd.Parameters.AddWithValue("@Phone", phone);
                Connection.cmd.Parameters.AddWithValue("@Address", Address);

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
        public static Client GetProfileClient(string phone)
        {
            Client c = new Client();
            try
            {
                string sqlQuery = "select * from tb_client where _phone_number=@phone;";
                Connection.OpenConnection();
                Connection.cmd.CommandType = System.Data.CommandType.Text;
                Connection.cmd.CommandText = sqlQuery;

                Connection.cmd.Parameters.Clear();
                Connection.cmd.Parameters.AddWithValue("@phone", phone);

                Connection.rd = Connection.cmd.ExecuteReader();

                while (Connection.rd.Read())
                {
                    c.Phone_number = Connection.rd.GetString(1);
                    c.Name_client = Connection.rd.GetString(0);
                    c.Address_client = Connection.rd.GetString(2);
                }
                return c;
            }
            catch (Exception e)
            {
                MessageBox.Show("getprofile error: " + e.Message);
                return c;

            }
            finally
            {
                Connection.CloseConnection();

            }

        }

        //public static UpdateClient(string phone)
        //{

        //}

    }
}
