using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SharedLibrary;
using System.Data;

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
        /// <summary>
        /// Helper method for reading a query row as a List<string>
        /// </summary>
        /// <param name="dataRecord"></param>
        private static List<string> ReadSingleRow(IDataRecord dataRecord)
        {
            // TODO
            List<string> returnList = new List<string>();
            for (int i = 0; i < dataRecord.FieldCount; i++)
                returnList.Add(dataRecord[i].ToString());
            //Console.WriteLine(String.Format("{0}, {1}", dataRecord[0], dataRecord[1]));
            return returnList;
        }
        /// <summary>
        /// Tests login for client
        /// </summary>
        /// <param name="loginName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Retrieves ListClass = List<Credentials>
        /// </summary>
        public ListClass GetUserCredentialList(string username)
        {
            ListClass credentialList = new ListClass();

            command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "select C.ID, C.ListID, C.TimeStamp, C.Password, C.UserName, C.Address, C.Title, C.Notes " +
                "from List as L " +
                "inner join AccountListMerge as AL " +
                "on AL.ListID = L.ID " +
                "inner join Account as A " +
                "on A.ID = AL.AccountID " +
                "inner join Credentials as C " +
                "on C.ListID = L.ID " +
                "where A.UserName = '" +
                username +
                "'";

            dataReader = command.ExecuteReader();
            while (dataReader.Read())
                credentialList.AddCredentialSlot(ReadSingleRow((IDataRecord)dataReader));
                //credentialList = credentialList + ReadSingleRow((IDataRecord)dataReader);

            connection.Close();
            return credentialList;
        }

        /// <summary>
        /// Retrieves list of user details
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public List<string> GetUserDetails(string username)
        {
            List<string> detailList = new List<string>();

            command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "select ID, UserName, RoleID, Email from Account where Account.UserName = '" +
            username +
            "' or Account.Email = '" + 
            username +
            "'";

            dataReader = command.ExecuteReader();
            while (dataReader.Read())
                detailList = ReadSingleRow((IDataRecord)dataReader);

            connection.Close();
            return detailList;
        }
    }
}
