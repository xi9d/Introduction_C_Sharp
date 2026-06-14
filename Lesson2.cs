using System;
namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            // if statements
            string name="Eddy";

            if(name=="Eddy")
            {
                Console.WriteLine("Eddy's world");
            }

            Console.WriteLine("Example using plater health");
            int playerhealth= 75;

            if (playerhealth<100)
            {
                Console.WriteLine("Player is damaged.Health:" +playerhealth);
            }       

            // write a program that checks if score is above 100(print high score)
            int score=800;

            if (score>100)
            {
                Console.WriteLine("High score");
            }
        }
    }
}