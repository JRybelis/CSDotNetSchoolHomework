using System;
using ISBN10ControlDigitGenerator.Interfaces;
using ISBN10ControlDigitGenerator.Loggers;

namespace ISBN10ControlDigitGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            IWriter writer = new ConsoleLogger();
            IReader reader = new ConsoleLogger();

            RequestUserInput requestUserInput = new(writer, reader);
            CalculateCheckDigit calculateCheckDigit = new();
            UserMessages userMessages = new(writer, requestUserInput);
            
            userMessages.ApplicationLaunchMessage("Hello. This tiny app will produce an ISBN-10 code with your help. " +
                                                  "It will take 9 digits you submit and generate the final " +
                                                  "10th control digit, returning you the full ISBN-10 code. Enjoy!");

            var userSupplied9Digits = userMessages.RequestFirst9ISBNDigits("Please enter a 9-digit-long-number, using a comma (no spaces) to separate each digit:");
            var checkDigit = calculateCheckDigit.FindTheISBNControlDigit(userSupplied9Digits);
            
            
            userMessages.PrintTheFullISBN10Out(userSupplied9Digits, checkDigit, "The ISBN-10 code is: ");
            
            reader.Read();
        }
    }
}