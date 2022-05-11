using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;

        public void Deposit(double amount)
        {
            Console.WriteLine($"{amount, 0:c}");
            _balance = amount;
        }
        public double GetBalance()
        {
            return _balance;
        }
    }
}
