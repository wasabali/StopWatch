using System;
namespace StopWatch
{
    public partial class Program
	{

        public static void Main (string[] args)
        {
            var myWatch = new StopWatch();
           
            Console.WriteLine("press spacebar to start");

            while (true)
            {
                if ((!myWatch.GetWatchActive()) && (Console.ReadKey().Key == ConsoleKey.Spacebar))
                {
                    myWatch.Start();
                    Console.WriteLine("staring stopwatch...");
                }
                
                if ((myWatch.GetWatchActive()) && (Console.ReadKey().Key == ConsoleKey.Spacebar))
                {
                    myWatch.Stop();
                    Console.WriteLine("stopping stopwatch...");
                    Console.WriteLine("duration: " + myWatch.Stop());
                }
            }

        }
	}
}

