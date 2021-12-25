using Scrypt;
using SharedLibrary;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

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
            List<string> returnList = new List<string>();
            for (int i = 0; i < dataRecord.FieldCount; i++)
                returnList.Add(dataRecord[i].ToString());

            return returnList;
        }
        /// <summary>
        /// Tests login for client
        /// </summary>
        /// <param name="loginName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string loginName, string password, string salt = "Y7-9v")
        {
            bool status = false;
            RandomNumberGenerator saltRng = RandomNumberGenerator.Create();
            ScryptEncoder hasher = new ScryptEncoder(4, 8, 2, saltRng);

            //Posibility to login with username or email
            command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "select Password from Account where UserName = '"
                + loginName
                + "' or Email = '"
                + loginName
                + "'";

            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                string hashedPassword = ReadSingleRow((IDataRecord)dataReader)[0];
                if (hasher.Compare(password, hashedPassword))
                    status = true;
            }

            connection.Close();
            return status;
        }
        /// <summary>
        /// Retrieves ListClass = List<Credentials>
        /// </summary>
        public ListClass GetUserCredentialList(string username)
        {

            string role = GetUserRole(username);

            ListClass credentialList = new ListClass();

            command = new SqlCommand();
            connection.Open();
            command.Connection = connection;

            if (role == "1")
            {
                command.CommandText = "select C.ID, C.ListID, C.TimeStamp, C.Password, C.UserName, C.Address, C.Title, C.Notes, L.Name " +
                "from List as L " +
                "inner join Credentials as C " +
                "on C.ListID = L.ID ";
            }
            else
            {
                command.CommandText = "select C.ID, C.ListID, C.TimeStamp, C.Password, C.UserName, C.Address, C.Title, C.Notes, L.Name " +
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
            }

            dataReader = command.ExecuteReader();
            while (dataReader.Read())
                credentialList.AddCredentialSlot(ReadSingleRow((IDataRecord)dataReader));

            connection.Close();
            return credentialList;
        }

        public void InsertCredentialSlot(string listId, string password, string username,
            string address, string title, string notes)
        {

            command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "insert into Credentials(ListID, Password, UserName, Address, Title, Notes, TimeStamp) " +
               "values (" +
               listId + ", '" +
               password + "', '" +
               username + "', '" +
               address + "', '" +
               title + "', '" +
               notes + "', " +
               "GETDATE())";

            command.ExecuteReader();

            connection.Close();
        }
        public void AddUserToList(string listId, string userId)
        {

            command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "insert into AccountListMerge(ListID, AccountID) " +
               "values (" +
               listId +
               ", " +
               userId + 
               ")";

            command.ExecuteReader();
            connection.Close();
        }
        public void AddNewList(string listName)
        {

            command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "insert into List(Name) " +
               "values ('" +
               listName +
               "')";

            command.ExecuteReader();
            connection.Close();
        }
        private string GetUserRole(string username)
        {
            string role = new string("");
            command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "select AR.ID as [Role Id], A.ID, Ar.Role from Account as A " +
                "inner join AccountRole as AR " +
                "on A.RoleID = AR.ID " +
                "where A.UserName = '" +
                username +
                "'";

            dataReader = command.ExecuteReader();
            if (dataReader.Read())
                role = ReadSingleRow((IDataRecord)dataReader)[0];

            connection.Close();
            return role;
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
