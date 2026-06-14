using System;

namespace Lesson4c
{
    class Program
    {
        private int age;
        private int score;

        public int playerhealth;

        // Property
        public int PlayerStat
        {
            get
            {
                return score;
            }

            set
            {
                score = value;
            }
        }

        static void Main(string[] args)
        {
            // accessing player health 
            Program pg = new Program();

            pg.playerhealth = 80;

        
            pg.PlayerStat = 90;

            Console.WriteLine(pg.playerhealth + pg.PlayerStat);
        }
    }
}