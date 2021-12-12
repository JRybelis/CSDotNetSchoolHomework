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

    public int GetIntegerInput()
    {
        var integerInput = int.Parse(_reader.Read());

        return integerInput;
    }
}