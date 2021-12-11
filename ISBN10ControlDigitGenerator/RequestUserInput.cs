using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<string> GetIntegerInput(string message)
        {
            _writer.WriteLine(message);
            
            var userStringInput = _reader.Read().Split(",");
            var output = userStringInput.ToList();
            //foreach (var digit in output.ToList()) digit;


            return output;

        }
    }
}