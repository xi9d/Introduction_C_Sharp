using System;
namespace Lesson2a
{
    class Program
    {
        static void Main(string[] args)
        {
            // if else statements
            string name= "Eddy";

            if (name=="Mark")
            {
                Console.WriteLine("Eddy's world");
            }else
            {
                Console.WriteLine($"{name} world");
            }

            Console.WriteLine("Example using score");
            int score=85;

            if (score>100)
            {
                Console.WriteLine("High score");
            }else
            {
                Console.WriteLine("Game over. Score: " +score);
            }
        }
    }
}