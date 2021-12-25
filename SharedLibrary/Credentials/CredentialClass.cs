using System.Collections.Generic;

namespace SharedLibrary
{
    public class CredentialClass
    {
        public string ID { get; set; }
        public string listID { get; set; }
        public string listName { get; set; }
        public string timeStamp { get; set; }
        public string password { get; set; }
        public string userName { get; set; }
        public string address { get; set; }
        public string title { get; set; }
        public string notes { get; set; }

        public CredentialClass()
        {

        }
        public CredentialClass(List<string> unencodedList)
        {
            ID = unencodedList[0];
            listID = unencodedList[1];
            timeStamp = unencodedList[2];
            password = unencodedList[3];
            userName = unencodedList[4];
            address = unencodedList[5];
            title = unencodedList[6];
            notes = unencodedList[7];
            listName = unencodedList[8];
        }
        /// <summary>
        /// Returns a list of all details
        /// </summary>
        /// <returns></returns>
        public List<string> GetList()
        {
            List<string> credentialList = new List<string> { ID, listID, timeStamp, password,
                userName, address, title, notes, listName};

            return credentialList;
        }
    }
}
