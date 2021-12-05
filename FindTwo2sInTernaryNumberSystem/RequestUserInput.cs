using System;
using FindTwo2sInTernaryNumberSystem.Interfaces;

namespace FindTwo2sInTernaryNumberSystem
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

            string? userStringInput = _reader.Read();

            int output = Int32.Parse(userStringInput);//todo throw exception when null. Catch it upstream. 
            
            return output;
        }
    }
}