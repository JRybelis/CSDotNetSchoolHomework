using System;

namespace FindTwo2sInTernaryNumberSystem
{
    public class CalculateData
    {
        public static int[] FindIntegerRangeMembers(int firstInteger, int lastInteger)
        {
            int integerRange = (lastInteger - firstInteger)+1;
            int[] integerRangeMembers = new int[integerRange];
            int position = integerRangeMembers[0];
            
            for (int i = firstInteger; i <= lastInteger; i++)
            {
                integerRangeMembers[position] = i;
                position++;
            }

            return integerRangeMembers;
        }
    }
}