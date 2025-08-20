using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Management_System
{
    public class BankAccount
    {
        protected int accountNumber;
        protected string holderName;
        protected double balance;
        protected static int totalAccounts;

        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        public string HolderName
        {
            get { return this.holderName; }
            set { this.holderName = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public static int TotalAccounts
        {
            get { return totalAccounts; }
            set { totalAccounts = value; }
        }

        public BankAccount()
        {

        }

        public BankAccount(int accountNumber, string holderName, double balance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.balance = balance;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Holder Name: " + holderName);
            Console.WriteLine("Banlance: " + balance);
        }
    }
}
