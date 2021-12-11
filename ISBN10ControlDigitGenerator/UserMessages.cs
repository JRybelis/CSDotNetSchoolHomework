using System.Collections.Generic;
using System.Linq;
using ISBN10ControlDigitGenerator.Interfaces;

namespace ISBN10ControlDigitGenerator
{
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
            _writer.Write(message);
        }

        public List<string> RequestFirst9ISBNDigits(string message)
        {
            List<string> first9Digits
                = _requestUserInput.GetIntegerInput(message);
            
            return first9Digits;
        }

        public void PrintTheFullISBN10Out(IEnumerable<string> first9ISBNDigits, string checkDigit, string message)
        {
            var FullISBN10Code = first9ISBNDigits.ToList();
            
            FullISBN10Code.Add(checkDigit);
            
            _writer.Write(message);
            
            
            foreach (var digit in FullISBN10Code)
            {
                _writer.Write("");
                _writer.Write(digit);
            }
        }
    }
}