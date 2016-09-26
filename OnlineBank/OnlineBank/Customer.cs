using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBank
{
    public class Customer
    {
        private System.Collections.ArrayList accounts;

        public Customer()
        {
            accounts = new System.Collections.ArrayList();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Id { get; set; }
        private bool error;

        public bool Error
        {
            get { return error; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }


        public Account GetAccount(int AccountIndex)
        {
            return (Account)accounts[AccountIndex];
        }

        public System.Collections.ArrayList GetAccounts()
        {
            return accounts;
        }

        public void CreateAccount(decimal InitialDeposit, string AccName)
        {
            if (InitialDeposit >= 1000)
            {
                Account a = new Account() { AccountName = AccName };
                a.Deposit(InitialDeposit);

                accounts.Add(a);
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

    public class Account
    {
        private decimal balance;
        public string AccountName { get; set; }
        public int Number { get; set; }

        public decimal Balance
        {
            get { return balance; }
        }

        public string AccountInfo
        {
            get { return string.Format("konto har {0} kr", Balance); }
        }

        public void Deposit(decimal amount)
        {
            balance = balance + amount;
        }

        public void Withdraw(decimal amount)
        {
            balance = balance - amount;

        }
    }
}
