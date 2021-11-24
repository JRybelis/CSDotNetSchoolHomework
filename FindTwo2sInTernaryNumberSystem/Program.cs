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
            
            
            Console.ReadLine();
            
        }
    }
}