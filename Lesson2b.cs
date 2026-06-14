using System;
namespace Lesson2b
{
    class Program
    {
        static void Main(string[] args)
        {
            int i =20;
            
            if(i==10)
            {
            Console.WriteLine("i is 10");
            }else if (i == 15)
            {
            Console.WriteLine("i is 15");
            }else if (i == 20)
            {
            Console.WriteLine("i is 20");
            }
            else
            {
                 Console.WriteLine("i is not present");
            }

            Console.WriteLine("Example using health");

            int health= 45;
            if (health <= 0)
            {
                Console.WriteLine("Player is dead");
            }else if (health < 30)
            {
                Console.WriteLine("Player is critical! Find med kit");
            }else if (health < 70)
            {
                Console.WriteLine("Player is wounded");
            }
            else
            {
                Console.WriteLine("player is healthy");
            }

            // nested if statements
            Console.WriteLine("Example using scoore and power up");

            int playerscore=100;
            bool hasPowerUp=true;
            
            if (playerscore>50)
            {
                Console.WriteLine("High score achieved");
                if (hasPowerUp)
                {
                    Console.WriteLine("Bonus points awarded");
                    playerscore +=20;
                }
            }
            Console.WriteLine($"Final score is {playerscore} ");

        
        }
    }
}