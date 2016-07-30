using System.Threading;

namespace AccountsLib
{
    public static class AccountFactory
    {
        public static Account CreateAccount(double bal)
        {
            Account account = new Account(Thread.CurrentThread.ManagedThreadId);
            account.Deposit(bal);
            return account;
        }
    }
}
