using System;
namespace Recap5
{
    class Program
    {
        static void Main(string[] args)
        {
            //*
            // **
            // ***
            // ****
            // *****
            for(int i = 1; i<= 5; i++)
            {
                for(int j = 1; j<=i;j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine("");

            }

            for (int r=5; r>=1; r--)
            {
                for(int t=r; t>=1; t--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        
                  
            
        
        }
    }
}