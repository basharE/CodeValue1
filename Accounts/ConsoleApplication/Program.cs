using System;
using AccountsLib;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            Account account = AccountFactory.CreateAccount(0);
            Account account1 = AccountFactory.CreateAccount(1000);
            Account account2 = AccountFactory.CreateAccount(1000);

            try
            {
                account2.Deposit(-100);
                account.Deposit(800);
                Console.WriteLine(account.Balance);
                account.Withdraw(100);
                Console.WriteLine(account.Balance);
                account.Transfer(account1, 500);

                Console.WriteLine(account.Balance);
                Console.WriteLine(account1.Balance);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("you can't use negative amount !!!");
            }
            catch (InsufficientFundsException)
            {
                Console.WriteLine("you don't have enough money in your account !!!");
            }
        }
    }
}
