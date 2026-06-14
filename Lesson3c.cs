using System;
namespace Lesson3c
{
    class Program
    {
        static void Main(string[] args)
        {
            // do-while loop
            int i=1;
            do
            {
                Console.WriteLine($"The value of i is {i}");
                i++;
            }while(i<0);

            // write a program that prints 10 to 1 using do while loop
            int number=10;
            do
            {
                Console.WriteLine($"The value is {number}");
                number--;
            }while(number>0);

            // write a program that prints odd numbers 1 to 20 using for loop
            for (int num=1; num<=20; num+=2)
            {
                Console.WriteLine($"{num}");
            }

            // write a program that finds the factorial of 5 using a for loop
            int factorial=1;
            for(int j=1; j<=5; j++)
            {
                factorial *=j;
            }
            Console.WriteLine($"The factorial of 5 is {factorial}");

        }
    }
}