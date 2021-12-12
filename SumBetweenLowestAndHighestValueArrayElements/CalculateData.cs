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
    
    
}