using System;
namespace Lesson1b
{
    class Progam
    {
        static void Main(string[] args)
        {
            // write a program that converts celcius to fahrenheit
            Console.WriteLine("Enter celcius value: ");
            double celcius= double.Parse (Console.ReadLine());
            double fahrenheit=celcius *9/5+32;
            Console.WriteLine($"Farenheit: {fahrenheit}");
        }
    }
}
