using System;
using FindTwo2sInTernaryNumberSystem.Interfaces;

namespace FindTwo2sInTernaryNumberSystem
{
    public class UserMessages
    {
        private readonly IWriter _writer;
        private readonly RequestUserInput _requestUserInput;
        private readonly CalculateData _calculateData;
        public UserMessages(IWriter writer, RequestUserInput requestUserInput, CalculateData calculateData)
        {
            _writer = writer;
            _requestUserInput = requestUserInput;
            _calculateData = calculateData;
        }

        public void ApplicationLaunchMessage()
        {
            _writer.Clear();
            _writer.Write("Hello. This tiny app will take two integer numbers you submit and check all the integers in their range for ternary numbers containing two 2s. Enjoy!");
        }

        /*public static void PrintRangeOfIntegers()
        {
            int a = RequestUserInput.GetIntegerInput("Please enter your first integer.");
            int b = RequestUserInput.GetIntegerInput("Please enter your second integer.");
            var integerRangeMembers = CalculateData.FindIntegerRangeMembers(a, b);
            
            Console.WriteLine("The range of integers, based on numbers you supplied:");
            
            foreach (var member in integerRangeMembers)
            {
                Console.Write($"\t{member}");
            }
        }
        */
        public void PrintResultsMessage(string message)
        {
            int a = _requestUserInput.GetIntegerInput("Please enter your first integer.");
            int b = _requestUserInput.GetIntegerInput("Please enter your second integer.");
            
            var integerRangeMembers = _calculateData.FindIntegerRangeMembers(a, b); 
            var ternaryNumbersToPrint = _calculateData.CollectTernariesWithTwo2S(integerRangeMembers);
            
            _writer.Write(message);
            _writer.Write("");

            foreach (var ternaryNumber in ternaryNumbersToPrint)
            {
                _writer.Write($"{ternaryNumber}");
            }
            
            _writer.Write("");
            _writer.Write("Thank you for using this app. Goodbye.");
        }

        
        
    }
}