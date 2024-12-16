using System;
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        bool running = true;
        Console.WriteLine("Stopwatch Program");
        Console.WriteLine("Press 'a' to Start, 'b' to Stop, 'r' to Reset, and 'q' to Quit.");
        while (running)
        {
            Console.WriteLine("Enter your Choice:");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();
            switch (input)
            {
                case 'a'://start
                    if (!stopwatch.IsRunning) { stopwatch.Start(); Console.WriteLine("Stopwatch started..."); }
                    else { Console.WriteLine("Stopwatch is already running."); }
                    break;
                case 'b'://stop
                    if (stopwatch.IsRunning) { stopwatch.Stop();
                    Console.WriteLine($"Stopwatch stopped. Elapsed time:{stopwatch.Elapsed}");}
                    else { Console.WriteLine("Stopwatch is not running."); }
                    break;
                case 'r'://Reset
                    stopwatch.Reset();
                    Console.WriteLine("Stopwatch reset.");
                    break;
                case 'q'://Quit
                    running = false;
                    Console.WriteLine("Exiting program. Goodbye!");
                    break;
                default: Console.WriteLine("invalid input. Please press 'a' , 'b' , 'r' , or 'q'.");
                    break;
            }
            

        }
    }
}