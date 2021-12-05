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
            UserMessages userMessages = new UserMessages(writer, reader);
            
            userMessages.ApplicationLaunchMessage();

            //UserMessages.PrintRangeOfIntegers();
            
            UserMessages.PrintResultsMessage("The range of integers, based on the numbers you supplied has the following numbers in ternary representation with two 2s in them:");

            Console.ReadLine();
            
        }
    }
}