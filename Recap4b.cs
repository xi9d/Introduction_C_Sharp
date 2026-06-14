using System;
namespace Recap4b
{
    class Program
    {
        
           // write a method that calculates the factorial of an integer (static method calling)
               public static int factorial()
        {
                  int num=5;
                  int factors  = 1;
                  for(int i =1;i<=num; i++)
            {
                factors *=i;
            }                        
            return factors;  

        }
       
            

        static void Main(string[] args)
        {
           int result= Program.factorial();
           Console.WriteLine($"The factorial of 5 is {result}");
        }
    }
}


