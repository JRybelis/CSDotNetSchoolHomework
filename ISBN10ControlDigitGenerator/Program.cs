using System;
using ISBN10ControlDigitGenerator.Interfaces;
using ISBN10ControlDigitGenerator.Loggers;

namespace ISBN10ControlDigitGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            IWriter writer = new ConsoleLogger();
            IReader reader = new ConsoleLogger();

            reader.Read();
        }
    }
}