using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary
{
    public struct ListInfo
    {
        public List<string> ListNames { get; set; }
        public int numberOfLists { get; set; }
        public int uniqueLists { get; set; }
        public void initListInfo()
        {
            ListNames = new List<string>();
            numberOfLists = 0;
        }
        public void addList(string listName)
        {
            ListNames.Add(listName);
            numberOfLists++;
        }
    }
    public class ListClass
    {
        public List<CredentialClass> credentialList { get; set; }
        public ListClass()
        {
            credentialList = new List<CredentialClass>();
        }
        public ListClass(List<CredentialClass> newList)
        {
            credentialList = newList;
        }
        public void AddCredentialSlot(CredentialClass credentialClass)
        {
            this.credentialList.Add(credentialClass);
        }
        public void AddCredentialSlot(List<string> credentialSlot)
        {
            CredentialClass tempCredential = new CredentialClass(credentialSlot);
            this.credentialList.Add(tempCredential);
        }
        static public ListClass operator+ (ListClass listClass, List<string> additionalCredentialList)
        {
            ListClass returnedListClass = new ListClass();
            returnedListClass = listClass;
            returnedListClass.AddCredentialSlot(additionalCredentialList);
            return returnedListClass;
        }
        public List<string> GetList()
        {
            List<string> returnList = new List<string>();
            for (int i = 0; i < credentialList.Count; i++)
            {
                var tempList = credentialList[i].GetList();
                for (int j = 0; j < tempList.Count; j++)
                {
                    returnList.Add(tempList[j]);
                }
            }

            return returnList;
        }
        public List<List<string>> GetListOfLists()
        {
            List<List<string>> returnList = new List<List<string>>();
            for (int i = 0; i < credentialList.Count; i++)
            {
                returnList.Add(credentialList[i].GetList());
            }

            return returnList;
        }
    }
}
