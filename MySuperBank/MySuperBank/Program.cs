using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Michael", 50);
            Console.WriteLine($"Account {account.Number}" +
                $" was created for {account.Balance} with {account.Owner}");
            account.MakeWithdrawal(40, DateTime.Now, "Hammock");
            Console.WriteLine(account.Balance);
        }
    }
}
