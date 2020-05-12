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

        public TransactionClass()
        {
            transactionAccess = bankDb.GetTransactionInterface();
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
            bankDb.SaveToDisk();
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

        public void ProcessAndSave()
        {
            bankDb.ProcessAllTransactions();
            bankDb.SaveToDisk();
        }
    }
}