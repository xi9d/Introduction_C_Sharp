using System;
namespace Lesson4a
{
    class Program
    {
        public void sayHello()
        {
        
            
                Console.WriteLine("Hello from my function");
            }
            static void Main(string[] args)
            {
                // methods in c sharp
                Program pg= new Program();
                pg.sayHello(); 
            }
            public void fullName()
        {
             Console.WriteLine("My full name is eddy");
        }
        static void Main(string[] args)
        {
            Program pg= new Program();
            pg.fullName();
        }

        public int sum()
        {
            int a=5;
            int b=10;

            return a+b;
        }
       
    }
}