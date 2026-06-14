using System;
namespace Lesson6c
{

    public abstract class Appliance
    {
        // regular methods
        public void PlugIn()
        {
            Console.WriteLine("Appliance plugged into outlet");
        }

        // abstract method no body implementation, implemented by child
        public abstract void TurnOn();
    }

    public class Microwave : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Microwave: Generating heat waves, heating food");
        }
    }

     // create another class washing machine implement two methods: spinDry();  turnOn(); 
     // inherit from appliance

    public class WashingMachine : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Washing Machine: Starting wash cycle");
        }

        public void SpinDry()
        {
            Console.WriteLine("Washing Machine: Spin drying clothes");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // abstract in csharp
            Microwave myMicrowave = new Microwave();
            myMicrowave.PlugIn();
            myMicrowave.TurnOn();

            // Testing WashingMachine
            WashingMachine myWashingMachine = new WashingMachine();
            myWashingMachine.PlugIn();
            myWashingMachine.TurnOn();
            myWashingMachine.SpinDry();
        }
    }
}