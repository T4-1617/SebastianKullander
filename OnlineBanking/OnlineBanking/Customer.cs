using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking
{
    class Customer
    {
        private System.Collections.ArrayList _accounts;

        public Customer()
        {
            _accounts = new System.Collections.ArrayList();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Int32 PersonalID { get; set; }
        private bool error;

        public bool Error
        {
            get { return error; }
        }

        public Account GetAccount(int AccountIndex)
        {
            return (Account)_accounts[AccountIndex];
        }

        public System.Collections.ArrayList GetAccounts()
        {
            return _accounts;
        }

        public void CreateAccount(decimal InitialDeposit, string AccName)
        {
            if (InitialDeposit >= 1000)
            {
                Account a = new Account() { AccountName = AccName };
                a.Deposit(InitialDeposit);

                _accounts.Add(a);
                error = false;
            }

            else
            {
                error = true;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }

    public class Account
    {
        private decimal balance;
        public string AccountName { get; set; }
        private bool error;

        public bool Error
        {
            get { return error; }
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public void Deposit(decimal amount)
        {
            balance = balance + amount;
        }

        public void withdraw(decimal amount)
        {
            if (balance - amount >= 500)
            {
                balance = balance - amount;
                error = false;
            }

            else
            {
                error = true;
            }
        }


    }

    public class Transaction
    {
        public string CustomerName { get; set; }
        public string AccountName { get; set; }
        public decimal TransactionAmount { get; set; }
        public string TransactionType { get; set; }
        public string TransactionWord { get; set; }

        public override string ToString()
        {
            return string.Format("{0} har {1} {2} kr {3} kontot \"{4}\" ", CustomerName, TransactionType, TransactionAmount, TransactionWord, AccountName);
        }

    }
}

