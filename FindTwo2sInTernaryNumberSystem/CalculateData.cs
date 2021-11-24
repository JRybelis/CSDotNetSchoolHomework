using System;

namespace FindTwo2sInTernaryNumberSystem
{
    public class CalculateData
    {
        public static int[] FindIntegerRangeMembers(int firstInteger, int lastInteger)
        {
            int integerRange = lastInteger - firstInteger;
            int[] integerRangeMembers = new int[integerRange];
            
            for (int i = firstInteger; i <= lastInteger; i++)
            {
                int position = integerRangeMembers[0]; //todo: look for a way to avoid this re-setting of position each loop
                integerRangeMembers[position] = i;
                position++;
                
                Console.WriteLine($"Integer range member from for loop: ",i);
                Console.WriteLine($"Integer range members array position the above went into:", position);
            }

            return integerRangeMembers;
        }
    }
}