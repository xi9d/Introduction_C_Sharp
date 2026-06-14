using System;
namespace Lesson6a
{

    public class Shape
    {
        public virtual double CalculateArea()
        {
            Console.WriteLine("The area of this shape");
            return 0;
        }
    }
    public class Circle : Shape
    {

        public override double CalculateArea()
        {
            Console.WriteLine("The area of the circle");
            return 0;
        }
          public double printArea()
         {
             Console.WriteLine("The area will be calaculated");
             return 0;
         }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // polymorphism
            Circle myShape= new Circle(); //instance of the cirle area\
            myShape.CalculateArea();
            myShape.printArea();

        }
    }
}