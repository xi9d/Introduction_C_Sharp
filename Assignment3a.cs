using System;

namespace Lesson4c
{
    class Program
    {
        // Method with parameter
        public int FindLargest(int[] numbers)
        {
            int largest = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }

            return largest;
        }

        static void Main(string[] args)
        {
            Program pg = new Program();

            int[] arr = { 1, 5, 4, 7, 2, 9, 3 };

            int result = pg.FindLargest(arr);

            Console.WriteLine("Largest number is: " + result);
        }
    }
}