using System;
namespace Recap2
{
    class Program
    {
        static void Main(string[] args)
        {
           int a;
            int b;
            Console.WriteLine("Enter the value of a: ");
            a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of b: ");
            b=Convert.ToInt32(Console.ReadLine());

            if (a>b)
            {
                Console.WriteLine("a is larger than b");
            }
            else
            {
                Console.WriteLine("b is larger than a");
            }

            // read a students mark and print :(switch case )
            int mark=60;
            switch (mark)
            {
                case >=80 and <=100:
                Console.WriteLine("Grade A");
                break;

                case >=70 and <=79:
                Console.WriteLine("Grade B");
                break;

                case >=60 and <=69:
                Console.WriteLine("Grade C");
                break;

                case >=50 and <=59:
                Console.WriteLine("Grade D");
                break;

                case >=0 and <=50:
                Console.WriteLine("Grade F");
                break;

                 default:
                Console.WriteLine("Invalid marks");
                break;


               

        }
    }
}
}