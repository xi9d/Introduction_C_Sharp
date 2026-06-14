using System;
namespace Recap2
{
    class Program
    {
        public int modulusNumber()
        {
            int a=5;
            int b=10;

            return a%b;
        }
        static void Main(string[] args)
        {
        //   write a method that finds modulus of two numbers without parameters(direct method)
        Program pg= new Program();
                int result= pg.modulusNumber(); 
                Console.WriteLine($"{result}");
        }
        
        
    }
}