
using System;
namespace Recap1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1: write a progam that asks the user for their name and prints
            Console.WriteLine("Whats your name?");
            string name =Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        
          // 2:Write a program that reads two integers and prints their :(variable, input ,output)
            //sum
            int num1=40;
            int num2=20;

            int sum= num1+num2;
            Console.WriteLine($"The sum is {sum}");

            // difference 
            
            int difference= num1-num2;
            Console.WriteLine($"The difference is {difference}");

            // product
            
            int product= num1*num2;
            Console.WriteLine($"The product is {product}");


            }
                
    }
}