using SumBetweenLowestAndHighestValueArrayElements.Interfaces;

namespace SumBetweenLowestAndHighestValueArrayElements.Loggers;

public class ConsoleLogger : IWriter, IReader
{
    public void Clear()
    {
        Console.Clear();
    }

    public void WriteLine(string input)
    {
        Console.WriteLine(input);
    }

    public void Write(string input)
    {
        Console.Write(input);
    }

    public string? Read()
    {
        return Console.ReadLine();
    }
}