using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankDB;

namespace BusinessLogic.BLL
{
    public class AccountClass
    {
        BankDB.BankDB bankDb = new BankDB.BankDB();
        private AccountAccessInterface accountAccess;

        public AccountClass()
        {
            accountAccess = bankDb.GetAccountInterface();
        }

        public void SelectAccount(uint accountID)
        {
            accountAccess.SelectAccount(accountID);
        }

        public List<uint> GetAccountIDsByUser(uint userID)
        {
            return accountAccess.GetAccountIDsByUser(userID);
        }

        public uint CreateAccount(uint userID)
        {
            uint accountId = accountAccess.CreateAccount(userID);
            bankDb.SaveToDisk();
            return accountId;
        }

        public void Deposit(uint amount)
        {
            accountAccess.Deposit(amount);
            bankDb.SaveToDisk();
        }

        public void Withdraw(uint amount)
        {
            accountAccess.Withdraw(amount);
            bankDb.SaveToDisk();
        }

        public uint GetBalance()
        {
            return accountAccess.GetBalance();
        }

        public bool isBalanceAvailable(uint amount)
        {
            return accountAccess.GetBalance() > amount;
        }

        public uint GetOwner()
        {
            return accountAccess.GetOwner();
        }
    }
}
