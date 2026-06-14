using System;

namespace Lesson5a
{
    public class BankAccount
    {
        private double balance;
        private string password;

        public BankAccount(double initialBalance, string pwd)
        {
            balance = initialBalance;
            password = pwd;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited : {amount}. New balance:{balance}");
            }
        }

        public void checkBalance()
        {
            Console.WriteLine($"Your balance is {balance}");
        }

       public void withdraw()
{
    Console.Write("Enter amount to withdraw: ");
    double amount = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter password: ");
    string enteredPassword = Console.ReadLine();

    if (enteredPassword != password)
    {
        Console.WriteLine("Incorrect password.");
        return;
    }

    if (amount > balance)
    {
        Console.WriteLine("Insufficient balance.");
        return;
    }

    if (amount <= 0)
    {
        Console.WriteLine("Invalid amount.");
        return;
    }

    balance -= amount;

    Console.WriteLine($"The amount withdrawn is {amount}");
    Console.WriteLine($"New balance is {balance}");
}
    }   


    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount(1000, "1234");
            // myAccount.balance=1000000;

            myAccount.Deposit(500);
            myAccount.checkBalance();
            myAccount.withdraw();
        }
    }
}   