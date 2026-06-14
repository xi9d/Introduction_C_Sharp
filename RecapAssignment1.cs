using System;

namespace RecapAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= 5; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}