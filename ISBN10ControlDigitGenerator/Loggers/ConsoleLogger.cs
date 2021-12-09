using System;
using ISBN10ControlDigitGenerator.Interfaces;

namespace ISBN10ControlDigitGenerator.Loggers
{
    public class ConsoleLogger : IWriter, IReader
    {
        public void Clear()
        {
            Console.Clear();
        }

        public void Write(string input)
        {
            Console.WriteLine(input);
        }

        public string? Read()
        {
            return Console.ReadLine();
        }
    }
}