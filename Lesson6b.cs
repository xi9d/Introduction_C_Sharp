using System;
namespace Lesson6b
{

    public interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        // implementation of the ishape class
        public double radius{get; set;}

        public Circle (double radius)
        {
            this.radius= radius;
        }
        public double CalculateArea()
        {
            
        }
    }

    // create a derived class rectangle with length and width properties and function override calaculateArea for the rectangle
    public class Rectangle: IShape
    {
        public double length {get;set;}
        public double width {get;set;}

        public Rectangle (double length ,double width)
        {
            this.length=length;
            this.width=width;
        }
        public override double CalculateArea()
        {
            return length * width;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle= new Circle(14.0);
            Console.WriteLine(myCircle.CalculateArea());
        }
    }
}