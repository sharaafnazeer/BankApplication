using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankDB;

namespace BusinessLogic.BLL
{
    class TransactionClass
    {
        BankDB.BankDB bankDb = new BankDB.BankDB();
        private TransactionAccessInterface transactionAccess;

        public TransactionClass()
        {
            transactionAccess = bankDb.GetTransactionInterface();
        }

        public void SelectTransaction(uint TransactionID)
        {
            throw new NotImplementedException();
        }

        public List<uint> GetTransactions()
        {
            throw new NotImplementedException();
        }

        public uint CreateTransaction()
        {
            throw new NotImplementedException();
        }

        public uint GetAmount()
        {
            throw new NotImplementedException();
        }

        public uint GetSendrAcct()
        {
            throw new NotImplementedException();
        }

        public uint GetRecvrAcct()
        {
            throw new NotImplementedException();
        }

        public void SetAmount(uint amount)
        {
            throw new NotImplementedException();
        }

        public void SetSendr(uint acctID)
        {
            throw new NotImplementedException();
        }

        public void SetRecvr(uint acctID)
        {
            throw new NotImplementedException();
        }
    }
}
