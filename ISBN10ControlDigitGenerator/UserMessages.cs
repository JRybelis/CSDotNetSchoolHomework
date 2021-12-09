using System.Collections.Generic;
using ISBN10ControlDigitGenerator.Interfaces;

namespace ISBN10ControlDigitGenerator
{
    public class UserMessages
    {
        private readonly IWriter _writer;
        private readonly RequestUserInput _requestUserInput;
        private readonly CalculateCheckDigit _calculateCheckDigit;

        public UserMessages(IWriter writer, RequestUserInput requestUserInput, CalculateCheckDigit calculateCheckDigit)
        {
            _writer = writer;
            _requestUserInput = requestUserInput;
            _calculateCheckDigit = calculateCheckDigit;
        }

        public void ApplicationLaunchMessage()
        {
            _writer.Clear();
            _writer.Write("Hello. This tiny app will produce an ISBN-10 code with your help. " +
                          "It will take 9 digits you submit and generate the final " +
                          "10th control digit, returning you the full ISBN-10 code. Enjoy!");
        }

        public void PrintResultsMessage(string message)
        {
            List<string> first9Digits
                = _requestUserInput.GetIntegerInput("Please enter a 9-digit-long-number:");
        }
    }
}