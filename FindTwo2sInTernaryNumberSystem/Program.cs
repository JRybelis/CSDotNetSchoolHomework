using System;
using FindTwo2sInTernaryNumberSystem.Interfaces;
using FindTwo2sInTernaryNumberSystem.Loggers;

namespace FindTwo2sInTernaryNumberSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            IWriter writer = new ConsoleLogger();
            IReader reader = new ConsoleLogger();
            
            RequestUserInput requestUserInput = new(writer, reader);
            CalculateData calculateData = new();
            UserMessages userMessages = new(writer, requestUserInput, calculateData);
            
            userMessages.ApplicationLaunchMessage();

            //UserMessages.PrintRangeOfIntegers();
            
            userMessages.PrintResultsMessage("The range of integers, based on the numbers you supplied has the following numbers in ternary representation with two 2s in them:");

            reader.Read();
            
        }
    }
}