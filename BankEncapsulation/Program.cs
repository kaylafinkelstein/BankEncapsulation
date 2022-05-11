using System;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();

            Console.WriteLine("What is your deposit?");
            double amountToDeposit = double.Parse(Console.ReadLine());

            ba.Deposit(amountToDeposit);

            double userBalance = ba.GetBalance();

            Console.WriteLine($"Your balace is: {userBalance,0:c}");
        }
    }
}
