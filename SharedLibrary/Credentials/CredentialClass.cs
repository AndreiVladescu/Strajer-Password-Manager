using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary
{
    public class CredentialClass
    {
        public string ID { get; set; }
        public string listID { get; set; }
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
            userName = unencodedList[4];
            address = unencodedList[5];
            title = unencodedList[6];
            notes = unencodedList[7];
        }
        public List<string> GetList()
        {
            List<string> credentialList = new List<string> { ID, listID, timeStamp,
                userName, address, title, notes };

            return credentialList;
        }
    }
}
