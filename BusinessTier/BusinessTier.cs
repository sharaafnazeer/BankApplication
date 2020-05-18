using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier;

namespace BusinessTier
{
    public class BusinessTier
    {
        private DataTier.DataTier data;
        public BusinessTier()
        {
            data = (DataTier.DataTier) Activator.GetObject(typeof(DataTier.DataTier), "http://localhost:8082/Data");
            if (data == null)
            {
                Console.WriteLine("Server Busy");
            }

        }

        public void SelectUser(uint userID)
        {
            data.SelectUser(userID);
        }

        public async Task<ArrayList> GetUsers()
        {
            ArrayList users = new ArrayList();
            await Task.Run(() => {
                users = data.GetUsers();
            });

            return users;
        }

        public uint CreateUser()
        {
            uint userID = data.CreateUser();
            SaveToDb();
            return userID;
        }

        public void GetUserName(out string fname, out string lname)
        {
            data.GetUserName(out fname, out lname);
        }

        public void SetUserName(string fname, string lname)
        {
            data.SetUserName(fname, lname);
            SaveToDb();
        }



        public void SelectAccount(uint accountID)
        {
            data.SelectAccount(accountID);
        }

        public async Task<ArrayList> GetAccountIDsByUser(uint userID)
        {
            ArrayList accounts = new ArrayList();
            await Task.Run(() => { accounts =
                accounts = data.GetAccountIDsByUser(userID);
            });
            
            return accounts;
        }

        public uint CreateAccount(uint userID)
        {
            uint accountId = data.CreateAccount(userID);
            SaveToDb();
            return accountId;
        }

        public void Deposit(uint amount)
        {
            data.Deposit(amount);
            SaveToDb();
        }

        public void Withdraw(uint amount)
        {
            data.Withdraw(amount);
            SaveToDb();
        }

        public uint GetBalance()
        {
            return data.GetBalance();
        }

        public bool isBalanceAvailable(uint amount)
        {
            return GetBalance() > amount;
        }

        public uint GetOwner()
        {
            return data.GetOwner();
        }




        public void SelectTransaction(uint TransactionID)
        {
            data.SelectTransaction(TransactionID);
        }

        public async Task<ArrayList> GetTransactions()
        {

            ArrayList transactions = new ArrayList();
            await Task.Run(() =>
            {
                transactions = data.GetTransactions();
            });

            return transactions;
        }

        public uint CreateTransaction()
        {
            uint transationID = data.CreateTransaction();
            return transationID;
        }

        public uint GetAmount()
        {
            return data.GetAmount();
        }

        public uint GetSendrAcct()
        {
            return data.GetSendrAcct();
        }

        public uint GetRecvrAcct()
        {
            return data.GetRecvrAcct();
        }

        public void SetAmount(uint amount)
        {
            data.SetAmount(amount);
        }

        public void SetSendr(uint acctID)
        {
            data.SetSendr(acctID);
        }

        public void SetRecvr(uint acctID)
        {
            data.SetRecvr(acctID);
        }


        public async Task<ArrayList> GetTransactionsByAccount(uint accountID)
        {
            ArrayList transactionList = await GetTransactions();

            ArrayList finalList = new ArrayList();


            foreach (var tran in transactionList)
            {
                SelectTransaction(Convert.ToUInt32(tran));
                if (GetSendrAcct() == accountID)
                {
                    finalList.Add(tran);
                }
            }

            return finalList;
        }

        public void SaveToDb()
        {
            data.save();
        }

        public void ProcessTransaction()
        {
            data.process();
        }

    }
}
