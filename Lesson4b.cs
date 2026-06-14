using System;
namespace Lesson4a
{
    class Program
    {
        public static int area(int length, int width)
        {
            return length*width;
        }
         public int area2(int length, int width)
        {
            return length*width;
        }
        static void Main(string[] args)
        {
            // accessing methods using static methos calling 
            // find area of a rectangle
            int area_result= Program.area(5,10);
            Console.WriteLine($"The area of a rectangle is {area_result}; ");

            // accessing methods using direct method calling
            Program pg = new Program();
            int area_result2= pg.area2(7,12);
            Console.WriteLine($"The area of a rectangle (direct method) is{area_result2})");

        }
    }
}