using SumBetweenLowestAndHighestValueArrayElements.Interfaces;

namespace SumBetweenLowestAndHighestValueArrayElements;

public class UserMessages
{
    private readonly IWriter _writer;
    private readonly RequestUserInput _requestUserInput;

    public UserMessages(IWriter writer, RequestUserInput requestUserInput)
    {
        _writer = writer;
        _requestUserInput = requestUserInput;
    }

    public void ApplicationLaunchMessage(string message)
    {
        _writer.Clear();
        _writer.WriteLine(message);
    }

    public int RequestArrayLength(string message)
    {
        _writer.WriteLine(message);
        var arrayLength = _requestUserInput.GetIntegerInput();

        if (arrayLength < 1)
        {
            _writer.WriteLine(message);
            arrayLength = _requestUserInput.GetIntegerInput();
        }

        return arrayLength;
    }
}