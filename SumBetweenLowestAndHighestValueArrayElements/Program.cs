using System;
using SumBetweenLowestAndHighestValueArrayElements.Interfaces;
using SumBetweenLowestAndHighestValueArrayElements.Loggers;

namespace SumBetweenLowestAndHighestValueArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            IWriter writer = new ConsoleLogger();
            IReader reader = new ConsoleLogger();

            RequestUserInput requestUserInput = new(writer, reader);
            UserMessages userMessages = new(writer, requestUserInput);
            CalculateData calculateData = new();
            
            userMessages.ApplicationLaunchMessage("Hello. This tiny app will produce an array of " +
                                                  "integers and, also, add the range of its elements " +
                                                  "together. Only the elements between the leftmost " +
                                                  "smallest one (inclusive) and the rightmost" +
                                                  " largest one (inclusive) will be added up. Enjoy!");

            var userChosenLengthOfArray = userMessages.RequestArrayLength("Please enter an " +
                "integer number to set the length of the array. Make sure it is higher than 1.");

            var userPopulatedArrayOfIntegers = userMessages.GetUserToPopulateArray(userChosenLengthOfArray);
            
            var leftmostLowestArrayElement
                = calculateData.FindTheLeftmostLowestArrayElementPosition(userPopulatedArrayOfIntegers);
            
            var rightmostHighestArrayElement = calculateData.FindTheRightmostHighestArrayElementPosition(userPopulatedArrayOfIntegers);
            
            userMessages.PrintTheResultingArray(userPopulatedArrayOfIntegers, "Please find " +
                "the array of integers you created below:");

            var leftTrimmedArray
                = calculateData.RemoveAnyElementsLeftOfTheLowestFromTheArray(
                    userPopulatedArrayOfIntegers, leftmostLowestArrayElement);
            
            var rightTrimmedArray
                = calculateData.RemoveAnyElementsRightOfTheHighestFromTheArray(leftTrimmedArray
                    , rightmostHighestArrayElement);

            var trimmedArrayElementSum
                = calculateData.AddRemainingArrayElementsTogether(rightTrimmedArray);
            
            userMessages.PrintTrimmedArrayElementsBeingAddedTogether(rightTrimmedArray, 
                trimmedArrayElementSum, "Please see the array elements from the lowest to the " +
                                        "highest value element being added together, below: ");
            
            writer.WriteLine("");
            writer.WriteLine("Thank you for using this app. Goodbye.");
            reader.Read();
        }
    }
}