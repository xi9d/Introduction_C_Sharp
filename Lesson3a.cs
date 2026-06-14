using System;
namespace Lesson3a
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=1;

            while (x <= 4)
            {
                Console.WriteLine("Eddy,s world");

                x++;
            }

            Console.WriteLine("Example using countdown from 5 to 1");

            int countdown=5;
            while (countdown >= 1) 
            {
                Console.WriteLine($"countdown {countdown}");
                countdown--;
            }

            // write a program that prints 0 to 100 using while loop
            int count=0;
            while (count <= 100) 
            {
                Console.WriteLine(count);
                count++;
            }

            // write a program that prints the sum of numbers from 0 to 21
            int sum=0;
            int number=0;
            while (number <=21)
            {
                sum +=number;
                number++;
            }
            Console.WriteLine($"The sum of the numbers is {sum}");
        }
    }
}