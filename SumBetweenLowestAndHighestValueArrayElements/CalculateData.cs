namespace SumBetweenLowestAndHighestValueArrayElements;

public class CalculateData
{
    public int FindTheLeftmostLowestArrayElementPosition(int[] userProvidedArray)
    {
        var leftmostLowestArrayElement = userProvidedArray[0];

        for (int i = 1; i < userProvidedArray.Length; i++)
        {
            if (userProvidedArray[i] < leftmostLowestArrayElement)
            {
                leftmostLowestArrayElement = userProvidedArray[i];
            }
        }
        
        return leftmostLowestArrayElement;
    }
    
    public int FindTheRightmostHighestArrayElementPosition(int[] userProvidedArray)
    {
        var rightmostHighestArrayElement = userProvidedArray[0];

        for (int i = 1; i < userProvidedArray.Length; i++)
        {
            if (userProvidedArray[i] >= rightmostHighestArrayElement)
            {
                rightmostHighestArrayElement = userProvidedArray[i];
            }
        }
        return rightmostHighestArrayElement;
    }

    public int[] RemoveAnyElementsLeftOfTheLowestFromTheArray(int[] userProvidedArray
        , int leftmostLowestArrayElement)
    {
        int[] leftTrimmedArray = userProvidedArray;

        if (leftmostLowestArrayElement > 0)
        {
            for (var i = 0; i < leftmostLowestArrayElement; i++)
            {
                leftTrimmedArray = leftTrimmedArray.Where((_, index) => index != i)
                    .ToArray();
            }
        }
        return leftTrimmedArray;
    }
    
    public int[] RemoveAnyElementsRightOfTheHighestFromTheArray(int[] userProvidedArray
        , int rightmosthighestArrayElement)
    {
        int[] rightTrimmedArray = userProvidedArray;

        if (rightmosthighestArrayElement < userProvidedArray.Length)// todo check if out of bounds can happen here?
        {
            for (var i = userProvidedArray.Length; i > rightmosthighestArrayElement; i--)
            {
                rightTrimmedArray = rightTrimmedArray.Where((_, index) => index != i)
                    .ToArray();
            }
        }
        return rightTrimmedArray;
    }
    
    
}