using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Server
{
    public class SQLManager
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;

        public SQLManager(string serverName, string databaseName, string security = "SSPI")
        {
            string connectionString = "server=" + serverName + "; Initial Catalog=" + databaseName + ";Integrated Security=" + security;
            connection = new SqlConnection(connectionString);
        }
        public bool Login(string loginName, string password)
        {
            bool status = false;
            //Posibility to login with username or email
            command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "select ID from Account where (Password = '" 
                + password 
                + "' and UserName = '"
                + loginName
                + "') or(Password = '"
                + password 
                + "' and Email = '" 
                + loginName 
                + "')";

            dataReader = command.ExecuteReader();
            if (dataReader.Read())
                status = true;

            connection.Close();
            return status;
        }
    }
}
