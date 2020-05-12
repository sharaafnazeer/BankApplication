using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankDB;

namespace BusinessLogic.BLL
{
    public class UserClass
    {
        BankDB.BankDB bankDb = new BankDB.BankDB();
        private UserAccessInterface userAccess;
        public UserClass()
        {
            userAccess = bankDb.GetUserAccess();
        }

        public void SelectUser(uint userID)
        {
            userAccess.SelectUser(userID);
        }

        public List<uint> GetUsers()
        {
            return userAccess.GetUsers();
        }

        public uint CreateUser()
        {
            uint userID = userAccess.CreateUser();
            bankDb.SaveToDisk();
            return userID;
        }

        public void GetUserName(out string fname, out string lname)
        {
            userAccess.GetUserName(out fname, out lname);
        }

        public void SetUserName(string fname, string lname)
        {
            userAccess.SetUserName(fname, lname);
            bankDb.SaveToDisk();
        }
    }
}
