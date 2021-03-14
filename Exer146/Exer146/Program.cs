using System;
using Exer146.Entities.Exceptions;
using Exer146.Entities;

namespace Exer146
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double initialBalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Enter amount for withdraw: ");
                double withdrawAmount = double.Parse(Console.ReadLine());
                Account account = new Account(number, holder, initialBalance, withdrawLimit);
                account.Withdraw(withdrawAmount);
                Console.Write("New balance: " + account.Balance);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}
