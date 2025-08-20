using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Management_System
{
    public class CorrentAccount : BankAccount
    {
        private double overdraftLimit;
        private double transactionFee;

        public double OverdraftLimit
        {
            get { return this.overdraftLimit; }
            set { this.overdraftLimit = value; }
        }

        public double TransactionFee
        {
            get { return this.transactionFee; }
            set { this.transactionFee = value; }
        }

        public CorrentAccount () : base()
        {

        }

        public CorrentAccount(int accountNumber, string holderName, double balance, double overdraftLimit, double transactionFee)
            : base(accountNumber, holderName, balance)
        {
            this.overdraftLimit = overdraftLimit;
            this.transactionFee = transactionFee;
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Overdraft Limit: "+overdraftLimit);
            Console.WriteLine("Transaction Fee: "+transactionFee);
        }

        public bool CanWithdraw(double amount)
        {
            return amount <= (Balance + overdraftLimit);
        }

        public bool CanWithdraw(double amount, double fee)
        {
            return amount <= (Balance - fee + overdraftLimit);
        }
    }
}
