using System;
using FindTwo2sInTernaryNumberSystem.Interfaces;

namespace FindTwo2sInTernaryNumberSystem.Loggers
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