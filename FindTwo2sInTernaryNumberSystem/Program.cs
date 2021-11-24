using System;

namespace FindTwo2sInTernaryNumberSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            UserMessages.ApplicationLaunchMessage();

            int a = RequestUserInput.GetIntegerInput("Please enter your first integer.");
            int b = RequestUserInput.GetIntegerInput("Please enter your second integer.");

            int[] integerRangeMembers = CalculateData.FindIntegerRangeMembers(a, b);
            Console.WriteLine("The range from Program below:");
            foreach (var member in integerRangeMembers)
            {
                Console.WriteLine(member);
            }
            Console.ReadLine();
            
        }
    }
}