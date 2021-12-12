using System;
using SumBetweenLowestAndHighestValueArrayElements.Interfaces;
using SumBetweenLowestAndHighestValueArrayElements.Loggers;

namespace SumBetweenLowestAndHighestValueArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            IWriter writer = new ConsoleLogger();
            IReader reader = new ConsoleLogger();
            
            writer.WriteLine("");
            writer.WriteLine("Thank you for using this app. Goodbye.");
            reader.Read();
        }
    }
}