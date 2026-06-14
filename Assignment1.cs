using System;
namespace Assignment1
{
    class Progam
    {
        static void Main(string[] args)
        {
            int num1=10;
            int num2=5;

            // addition
            int sum= num1+num2;
            Console.WriteLine($"The sum is {sum}");

            // subtraction
            int subtraction=num1-num2;
            Console.WriteLine($"The difference is {subtraction}");

            // multiplication
             int multiplication=num1*num2;
            Console.WriteLine($"The product is {multiplication}");

            // division
             int division=num1/num2;
            Console.WriteLine($"The quotient is {division}");


            // Runtime program
            // first name
            string name;
            Console.WriteLine("Enter your first name: ");
            name=Console.ReadLine();

            // age
            int age;
            Console.WriteLine("Enter your age: ");
            age= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"My name is {name} and i am {age} old");
            
            


        }
    }
}