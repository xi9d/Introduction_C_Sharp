using System;
namespace Lesson1a
{
    class Progam
    {
        static void Main(string[] args)
        {
            // addition
            int a;
            int b;
            Console.WriteLine("Enter the value of a: ");
            a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of b: ");
            b=Convert.ToInt32(Console.ReadLine());

            int sum= a+b;
            Console.WriteLine($"The sum is {sum}");

            // subtraction
            int c;
            Console.WriteLine("Enter the value of c: ");
            c= Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter the value of a: ");
            a=Convert.ToInt32(Console.ReadLine());

             int subtraction= c-a;
            Console.WriteLine($"The subtraction is {subtraction}");

            // modulus
            int d;
            Console.WriteLine("Enter the value of d: ");
            d= Convert.ToInt32(Console.ReadLine());

            int modulus=a%d;
            Console.WriteLine($"The modulus is {modulus}");

            

        }
    }
}