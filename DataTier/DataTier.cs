using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankDB;

namespace DataTier
{
    public class DataTier : MarshalByRefObject
    {
        BankDB.BankDB bankDb = new BankDB.BankDB();
        private UserAccessInterface userAccess;
        private AccountAccessInterface accountAccess;
        private TransactionAccessInterface transactionAccess;

        public DataTier()
        {
            userAccess = bankDb.GetUserAccess();
            accountAccess = bankDb.GetAccountInterface();
            transactionAccess = bankDb.GetTransactionInterface();
        }

        public void SelectUser(uint userID)
        {
            userAccess.SelectUser(userID);
        }

        public ArrayList GetUsers()
        {

            ArrayList userArrayList = new ArrayList();
            var users = userAccess.GetUsers();
            users.ForEach(user => { userArrayList.Add(user); });
            return userArrayList;
        }

        public uint CreateUser()
        {
            uint userID = userAccess.CreateUser();
            return userID;
        }

        public void GetUserName(out string fname, out string lname)
        {
            userAccess.GetUserName(out fname, out lname);
        }

        public void SetUserName(string fname, string lname)
        {
            userAccess.SetUserName(fname, lname);
        }


        public void SelectAccount(uint accountID)
        {
            accountAccess.SelectAccount(accountID);
        }

        public ArrayList GetAccountIDsByUser(uint userID)
        {
            ArrayList accountsArrayList =  new ArrayList();
            var accounts = accountAccess.GetAccountIDsByUser(userID);
            accounts.ForEach(account => { accountsArrayList.Add(account); });
            return accountsArrayList;
        }

        public uint CreateAccount(uint userID)
        {
            uint accountId = accountAccess.CreateAccount(userID);
            return accountId;
        }

        public void Deposit(uint amount)
        {
            accountAccess.Deposit(amount);
        }

        public void Withdraw(uint amount)
        {
            accountAccess.Withdraw(amount);
        }

        public uint GetBalance()
        {
            return accountAccess.GetBalance();
        }

        public uint GetOwner()
        {
            return accountAccess.GetOwner();
        }



        public void SelectTransaction(uint TransactionID)
        {
            transactionAccess.SelectTransaction(TransactionID);
        }

        public ArrayList GetTransactions()
        {
            ArrayList tranArrayList = new ArrayList();
            var transactions = transactionAccess.GetTransactions();
            transactions.ForEach(transaction => { tranArrayList.Add(transaction); });
            return tranArrayList;

        }

        public uint CreateTransaction()
        {
            uint transationID = transactionAccess.CreateTransaction();
            return transationID;
        }

        public uint GetAmount()
        {
            return transactionAccess.GetAmount();
        }

        public uint GetSendrAcct()
        {
            return transactionAccess.GetSendrAcct();
        }

        public uint GetRecvrAcct()
        {
            return transactionAccess.GetRecvrAcct();
        }

        public void SetAmount(uint amount)
        {
            transactionAccess.SetAmount(amount);
        }

        public void SetSendr(uint acctID)
        {
            transactionAccess.SetSendr(acctID);
        }

        public void SetRecvr(uint acctID)
        {
            transactionAccess.SetRecvr(acctID);
        }

        public void save()
        {
            bankDb.SaveToDisk();
        }

        public void process()
        {
            bankDb.ProcessAllTransactions();
        }

    }
}
