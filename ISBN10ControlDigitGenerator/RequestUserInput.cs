using System;
using ISBN10ControlDigitGenerator.Interfaces;

namespace ISBN10ControlDigitGenerator
{
    public class RequestUserInput
    {
        private readonly IWriter _writer;
        private readonly IReader _reader;


        public RequestUserInput(IWriter writer, IReader reader)
        {
            _writer = writer;
            _reader = reader;
        }

        public int GetIntegerInput(string message)
        {
            _writer.Write(message);
            
            var userStringInput = _reader.Read();
            var output = int.Parse(userStringInput);

            return output;

        }
    }
}