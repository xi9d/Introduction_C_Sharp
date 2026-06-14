using System;
namespace Lesson3b
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loops
            for(int i=0; i<=10; i++)
            {
                Console.WriteLine($"The value of i is {i}");
            }

            for(int i=10; i>=1; i--)
            {
                Console.WriteLine($"The value of i is {i}");
            }

            // write a program that finds the sum of numbers 0 to 20
            int sum=0;
            for(int i=0; i<=20; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of numbers is {sum}");

            // print in using infinite loop
            int num=5;
            for (; ; )
            {
                Console.WriteLine("This is an infinite loop");
                if (num <= 10)
                {
                    num++;
                    continue;
                }
                else
                {
                    Console.WriteLine("End of the line");
                    break;
                }
            }
        }
    }
}