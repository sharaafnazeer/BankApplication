using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankDB;

namespace BusinessLogic.BLL
{
    public class TransactionClass
    {
        BankDB.BankDB bankDb = new BankDB.BankDB();
        private TransactionAccessInterface transactionAccess;
        private AccountClass accountClass;

        public TransactionClass()
        {
            transactionAccess = bankDb.GetTransactionInterface();
            accountClass = new AccountClass();
        }

        public void SelectTransaction(uint TransactionID)
        {
            transactionAccess.SelectTransaction(TransactionID);
        }

        public List<uint> GetTransactions()
        {
            return transactionAccess.GetTransactions();
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

        public List<uint> GetTransactionsByAccount(uint accountID)
        {
            List<uint> transactionList = GetTransactions();

            List<uint> finalList = new List<uint>();

            transactionList.ForEach(trans =>
            {
                SelectTransaction(trans);
                if (GetSendrAcct() == accountID)
                {
                    finalList.Add(trans);
                }
            });

            return finalList;
        }

        public void ProcessAndSave()
        {
            bankDb.ProcessAllTransactions();
            bankDb.SaveToDisk();
        }
    }
}