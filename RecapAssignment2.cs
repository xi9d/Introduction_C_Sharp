using System;

namespace RecapAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int gcd = 1;

            for(int i = 1; i <= num1 && i <= num2; i++)
            {
                if(num1 % i == 0 && num2 % i == 0)
                {
                    gcd = i;
                }
            }

            Console.WriteLine("GCD = " + gcd);
        }
    }
}