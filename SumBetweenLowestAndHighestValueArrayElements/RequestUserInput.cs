using SumBetweenLowestAndHighestValueArrayElements.Interfaces;

namespace SumBetweenLowestAndHighestValueArrayElements;

public class RequestUserInput
{
    private readonly IWriter _writer;
    private readonly IReader _reader;


    public RequestUserInput(IWriter writer, IReader reader)
    {
        _writer = writer;
        _reader = reader;
    }

    public int GetArrayLength(string message)
    {
        _writer.WriteLine(message);

        var arrayLength = int.Parse(_reader.Read());

        return arrayLength;
    }
}