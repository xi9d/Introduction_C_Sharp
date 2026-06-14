using System;
namespace Lesson5b
{

    public class Vehicle
    {
        public string brand{get; set;}

        public void start()
        {
            Console.WriteLine($"{brand} vehicle is starting...");
        }
        public void stop()
        {
            Console.WriteLine($"{brand} vehicle is stopping...");
        }

    }
    // child class inherits from vehicle 
    public class Motorcycle : Vehicle
{
    public bool hasSideCar {get; set;}

    public void Wheelie()
    {
        Console.WriteLine($"{brand} is doing a wheelie!");

        if(hasSideCar)
        {
            Console.WriteLine("But it has a sidecar attached.");
        }
    }
}
    public class Car : Vehicle
    {
        public string model{get;set;}
        public void Honk()
        {
            Console.WriteLine($"{brand} {model} says: Beep Beep");
        }
    }

    // assignment: create a child class motorcycle inherit from vehicle 
    // add bool hasSideCar, implement a wheelie function
    class Program
    {
        static void Main(string[] args)
        {
            // inheritance in csharp
            Car myCar= new Car();
            myCar.brand= "Mercedes";
            myCar.model="GLE";
            myCar.start();
            myCar.Honk();
            myCar.stop();

            Motorcycle myBike = new Motorcycle();

            myBike.brand = "Kawasaki";
            myBike.hasSideCar = false;

            myBike.start();
            myBike.Wheelie();
            myBike.stop();  
        }
    }
}