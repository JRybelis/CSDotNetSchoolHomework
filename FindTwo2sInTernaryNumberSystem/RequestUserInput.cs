using System;

namespace FindTwo2sInTernaryNumberSystem
{
    public class RequestUserInput
    {
        public static int GetIntegerInput(string message)
        {
            Console.WriteLine(message);
            string? userStringInput = Console.ReadLine();
            
            int output = Int32.Parse(userStringInput);
            
            return output;
        }
    }
}