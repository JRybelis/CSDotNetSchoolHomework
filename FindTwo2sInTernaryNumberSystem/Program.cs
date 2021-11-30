using System;

namespace FindTwo2sInTernaryNumberSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            UserMessages.ApplicationLaunchMessage();

            UserMessages.PrintRangeOfIntegers();
            
            UserMessages.PrintResultsMessage("The range of integers, based on the numbers you supplied has the following numbers in ternary representation with two 2s in them:");

            Console.ReadLine();
            
        }
    }
}