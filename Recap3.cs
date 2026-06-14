using System;
namespace Recap2
{
    class Program
    {
        static void Main(string[] args)
        {
        //   write a program that prints numbers 20 to 1 using a for loop
        for (int number=20; number>=1; number--)
            {
                Console.WriteLine($"The number is {number}");
            }

            // write a program that prints the mathematical table of the number 7(1-10) using a while loop
            int num=7;
            int multiple=1;

            while(multiple <= 10)
            {
                Console.WriteLine($"The multiple of {num} x {multiple} = {num *multiple}");
                multiple++;
            }
        }
    }
}