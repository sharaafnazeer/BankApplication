using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusinessTier
{
    public interface IBusinessTier
    {
        void SelectUser(uint userID);

        Task<ArrayList> GetUsers();

        uint CreateUser();

        void GetUserName(out string fname, out string lname);

        void SetUserName(string fname, string lname);

        void SelectAccount(uint accountID);

        Task<ArrayList> GetAccountIDsByUser(uint userID);

        uint CreateAccount(uint userID);

        void Deposit(uint amount);

        void Withdraw(uint amount);

        uint GetBalance();

        bool isBalanceAvailable(uint amount);

        uint GetOwner();

        void SelectTransaction(uint TransactionID);

        Task<ArrayList> GetTransactions();

        uint CreateTransaction();

        uint GetAmount();

        uint GetSendrAcct();

        uint GetRecvrAcct();

        void SetAmount(uint amount);

        void SetSendr(uint acctID);

        void SetRecvr(uint acctID);

        Task<ArrayList> GetTransactionsByAccount(uint accountID);

        void SaveToDb();

        void ProcessTransaction();
    }
}
