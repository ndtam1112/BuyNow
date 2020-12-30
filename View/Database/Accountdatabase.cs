using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using View.Classess;
using System.Data.SqlClient;
using View.User_Control;

namespace View.Database
{
    public class Accountdatabase
    {
        public static string sql;
        //Insert Account To Database
        public static bool insert(string phone, string password)
        {
            try
            {
                string sqlQuery = "insert into _tb_log_in values(@Phone,@Password);";

                Connection.OpenConnection();
                Connection.cmd.CommandType = System.Data.CommandType.Text;
                Connection.cmd.CommandText = sqlQuery;
                Connection.cmd.Parameters.Clear();
                Connection.cmd.Parameters.AddWithValue("@Phone", phone);
                Connection.cmd.Parameters.AddWithValue("@Password", password);

                Connection.cmd.ExecuteScalar();
                return true;

            }
            catch(Exception e)
            {
                MessageBox.Show("loi o phan insert to login " + e.Message);
                return false;
            }
            finally
            {
                Connection.CloseConnection();
            }
           
        }
        public static Boolean CheckAccount(string phone, string password)
        {

            string sqlQuery = $"select count(*) from _tb_log_in where _phone_number=@Phone and _pass_word=@Password;";
            try
            {
                Connection.OpenConnection();
                Connection.cmd.CommandType = CommandType.Text;
                Connection.cmd.CommandText = sqlQuery;
                Connection.cmd.Parameters.Clear();
                Connection.cmd.Parameters.AddWithValue("@Phone", phone);
                Connection.cmd.Parameters.AddWithValue("@Password", password);
                int count = Convert.ToInt32(Connection.cmd.ExecuteScalar().ToString());

                if (count != 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Email or Password not correct", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error connecting...", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            finally
            {
                Connection.CloseConnection();
            }


        }

       
    }
}
