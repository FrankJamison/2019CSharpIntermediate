using System;
using System.Reflection;
using System.Threading;

namespace Exercise1_DesignAStopwatch
{
    /*
     * Design a class called Stopwatch.
     * The job of this class is to simulate a stopwatch.
     * It should provide two methods: Start and Stop.
     * We call the start method first, and the stop method next.
     * Then we ask the stopwatch about the duration between start and stop.
     * Duration should be a value in TimeSpan.
     * Display the duration on the console.
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Create a stopwatch object
            var stopwatch = new Stopwatch();

            // Check initial state of stopwatch
            Console.WriteLine("Time Elapsed: " + stopwatch.Duration);

            // Run the stopwatch fpr 1 second
            stopwatch.Start();
            Thread.Sleep(1000);
            stopwatch.End();

            // Display time elapsed
            Console.WriteLine("Time Elapsed: " + stopwatch.Duration);
            
            // Reset the stopwatch
            stopwatch.Reset();

            // Display time elapsed
            Console.WriteLine("Time Elapsed: " + stopwatch.Duration);

            // Start the stopwatch twice
            stopwatch.Start();
            stopwatch.Start();

            // Run the stopwatch for 1 millisecond
            Thread.Sleep(1);

            // End the stopwatch twice
            stopwatch.End();
            stopwatch.End();

            // Display time elapsed
            Console.WriteLine("Time Elapsed: " + stopwatch.Duration);

            // Reset  the stopwatch
            stopwatch.Reset();

            // Display time elapsed
            Console.WriteLine("Time Elapsed: " + stopwatch.Duration);
        }
    }
}
