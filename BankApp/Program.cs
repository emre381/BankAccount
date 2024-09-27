using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    // deposit para yatırmak withdraw
     class Program
    {
        class BankAccount
        {
            private int accountBlance;
            public void withDraw(int amount)
            {
                accountBlance += amount;
            }
            public void deposit(int amount)
            {
                accountBlance -= amount;
            }
            public int accountBlanceCheck()
            {
                return accountBlance;
            }
        }
        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount();
            Console.WriteLine(b1.accountBlanceCheck());

            b1.withDraw(1500);
            Console.WriteLine("Amount in your bank account:" + b1.accountBlanceCheck());
            b1.deposit(100);
            Console.WriteLine("Amount in your bank account:" + b1.accountBlanceCheck());
            Console.ReadLine();


        }
    }
}
