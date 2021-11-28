using System;

namespace FindTwo2sInTernaryNumberSystem
{
    public class UserMessages
    {
        public static void ApplicationLaunchMessage()
        {
            Console.Clear();
            Console.WriteLine("Hello. This tiny app will take two integer numbers you submit and check all the integers in their range for ternary numbers containing two 2s. Enjoy!");
        }

        public static void PrintRangeOfIntegers()
        {
            int a = RequestUserInput.GetIntegerInput("Please enter your first integer.");
            int b = RequestUserInput.GetIntegerInput("Please enter your second integer.");
            int[] integerRangeMembers = CalculateData.FindIntegerRangeMembers(a, b);
            
            Console.WriteLine("The range of integers, based on numbers you supplied:");
            
            foreach (var member in integerRangeMembers)
            {
                Console.Write($"\t{member}");
            }
        }
        
        public static void PrintResultsMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
            Console.Write("Thank you for using this app. Goodbye.");
        }

        
        
    }
}