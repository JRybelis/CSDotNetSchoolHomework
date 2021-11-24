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

        public static void PrintResultsMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
            Console.Write("Thank you for using this app. Goodbye.");
        }
        
    }
}