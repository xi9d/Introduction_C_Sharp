using System;
using System.Threading;
using Microsoft.VisualBasic;
namespace GuessGame
{
    class GameBehaviour
    {
        public virtual void Start() {}
        public virtual void Update() {}
        public virtual void FixedUpdate() {}
        public virtual void DebugLog(string message)
        {
            Console.WriteLine($"   {DateTime.Now:HH:mm:ss} {message}");
        }

       
    }

    // child class inheriting from parent 
    class GuessGame : GameBehaviour
    {
        // properties 
        private int secretNumber;
        private int attempts;
        private int maxAttempts= 5;
        private bool isGameOver=false;

        // behaviour/ methods
        public override void Start()
        {
           Random rand=new Random();
           secretNumber=rand.Next(1,101);
           attempts=0;
           isGameOver=false;

          Console.WriteLine($"Guess the number (1-101)");
          Console.WriteLine($"You have {maxAttempts} attempts\n");
          DebugLog("Get started!!");

        }
        public override void Update()
        {
            if (isGameOver)
            {
                return;
            }
            Console.WriteLine($"Attempts {attempts+1}: ");
            int guess=Convert.ToInt32(Console.ReadLine());
            if (guess != null)
            {
                attempts++;
                if (guess == secretNumber)
                {
                    Console.WriteLine($"\n YOU WIN!!!!, IN {attempts} ATTEMPTS.");
                    DebugLog("Player Won");
                    isGameOver=true;
                }else if(attempts> maxAttempts)
                {
                    Console.WriteLine($"GAME OVER!!!! Number was {secretNumber}");
                    DebugLog("Player Lost");
                    isGameOver=true;
                }else if (guess < secretNumber)
                {
                    Console.WriteLine("Try again, Too Low\n");
                
                }
                else
                {
                    Console.WriteLine("Try again too High\n");
                    
                }
            }
            else
            {
                Console.WriteLine("Invalid input, Try again");
            }
            
        }
         public override void FixedUpdate()
        {
           if(!isGameOver && attempts>0 && attempts< maxAttempts)
            {
                Console.WriteLine("[FIXED UPDATE] Keep trying");
            }
        }
            
        
    }
    class GameEngine
    {   
        // properties
        private GuessGame game;
        private DateTime lastFixedUpdate;
        private const int FIXED_UPDATE_INTERVAL_MS=50;

        // behaviour 
        public void Run()
        {
            game= new GuessGame();
            game.Start();

            while (true)
            {
                game.Update();
                DateTime now=DateAndTime.Now;
                if((now-lastFixedUpdate).TotalMilliseconds >= FIXED_UPDATE_INTERVAL_MS)
                {
                    game.FixedUpdate();
                    lastFixedUpdate=now;
                }
                Thread.Sleep(16);
            }


        }
    }
    class Program
        {
            static void Main(string[] args)
            {
               GameEngine gameEngine=new GameEngine();
               gameEngine.Run();
            }
        }
}