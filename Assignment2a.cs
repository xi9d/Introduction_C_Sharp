using System;
namespace Assignment2a
{
    class Program
    {
        static void Main(string[] args)
        {
            int age=75;
            if (age<20)
            {
                Console.WriteLine("Child");

            }else if(age>=20 && age <60)
            {
                Console.WriteLine("Adult");

            }else if (age >= 60)
            {
                Console.WriteLine("Retired");
            }
        }
    }
}