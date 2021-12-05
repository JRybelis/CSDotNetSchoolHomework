using System;
using FindTwo2sInTernaryNumberSystem.Interfaces;

namespace FindTwo2sInTernaryNumberSystem
{
    public class UserMessages
    {
        private readonly IWriter _writer;
        private readonly IReader _reader;

        public UserMessages(IWriter writer, IReader reader)
        {
            _writer = writer;
            _reader = reader;
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
        public static void PrintResultsMessage(string message)
        {
            int a = RequestUserInput.GetIntegerInput("Please enter your first integer.");
            int b = RequestUserInput.GetIntegerInput("Please enter your second integer.");
            var integerRangeMembers = CalculateData.FindIntegerRangeMembers(a, b);
            var ternaryNumbersToPrint = CalculateData.CollectTernariesWithTwo2S(integerRangeMembers);
            
            Console.WriteLine(message);
            Console.WriteLine();
            
            foreach (var ternaryNumber in ternaryNumbersToPrint)
            {
                Console.Write($"\t{ternaryNumber}");
            }
            
            Console.WriteLine();
            Console.Write("Thank you for using this app. Goodbye.");
        }

        
        
    }
}