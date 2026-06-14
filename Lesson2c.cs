using System;
namespace Lesson2c
{
    class Program
    {
        static void Main(string[] args)
        {
            // switch statements
            int number=60;
            switch (number)
            {
                case 10:
                Console.WriteLine("The number is 10");
                break;

                case 20:
                Console.WriteLine("The number is 20");
                break;

                case 30:
                Console.WriteLine("The number is 30");
                break;

                default:
                Console.WriteLine("None matches");
                break;
            }
            Console.WriteLine("Example using days of the week");
            int day=3;
            switch (day)
            {
                case 1:
                Console.WriteLine("Sunday: Start of the week");
                break;

                case 2:
                Console.WriteLine("Monday: Second day of the week");
                break;

                case 3:
                Console.WriteLine("Tuesday: Keep going");
                break;

                case 4:
                Console.WriteLine("Wednesday: Half way there");
                break;

                 case 5:
                Console.WriteLine("Thursday: Almost there");
                break;

                 case 6:
                Console.WriteLine("Friday: Last day working");
                break;

                default:
                Console.WriteLine("Rest and recharge");
                break;


                
            }

            Console.WriteLine("Example using player ranks");
            string Rank="Gold";

            switch (Rank)
            {
                case "Bronze":
                Console.WriteLine("You are a bronze player");
                break;

                case "Silver":
                Console.WriteLine("You are a silver player");
                break;

                case "Gold":
                Console.WriteLine("You are a gold player great job");
                break;

                case "Platinum":
                Console.WriteLine("You are a platinum player nice");
                break;

                case "Diamond":
                Console.WriteLine("You are a diamond player");
                break;

                case "Heroic":
                Console.WriteLine("You are a heroic player");
                break;

                case "Master":
                Console.WriteLine("You are a master player");
                break;

                default:
                Console.WriteLine("You are a boot");
                break;
            }
        }
    }
}