using System;

namespace AccountsLib
{
    public class Account
    {
        private int _id;
        private double _balance;
        // a
        internal Account(int id)
        {
            _id = id;
        }

        // b 
        public int ID
        {
            get { return _id; }
        }

        //e
        public double Balance
        {
            get { return _balance; }
            private set { _balance = value; }
        }

        //c
        public void Deposit(double amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException();
            else
            {
                Balance += amount;
            }
        }

        //d
        public bool Withdraw(double amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException();
            else if (amount > Balance)
                throw new InsufficientFundsException();
            {
                Balance -= amount;
                return true;
            }
        }

        //f
        // No need to add exception throw, cause this method uses
        // the Withdarw method which include exceotion throw 
        public void Transfer(Account acc, double amount)
        {
            double bal = Balance;
            try
            {
                Withdraw(amount);
                acc.Balance += amount;
            }
            finally
            {
                Console.WriteLine("tramsfer attempt !!!");
                Console.WriteLine("the balance before is :"+ bal);
                Console.WriteLine("the balance after is :" + Balance);
            }
        }
    }
}
