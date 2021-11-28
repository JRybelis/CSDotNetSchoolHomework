using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

        public static List<int> ConvertIntegerRangeMemberToTernary(int integerRangeMember)
        {
            int dividend = integerRangeMember;
            int quotent;
            int lastDigit = dividend % 3;
            List<int> InverseTernaryOutput = new List<int>();
            List<int> TernaryIntegerDigits = new List<int>();
            do
            {
                InverseTernaryOutput.Add(lastDigit);
                
                quotent = dividend / 3;
                lastDigit = quotent % 3;
            } while (quotent != 0);

            InverseTernaryOutput.Reverse();
            TernaryIntegerDigits = InverseTernaryOutput.ToList();

            return TernaryIntegerDigits;
        }

        public static ArrayList CheckTernaryIntegersForTwo2s(int[] integerRangeMembers)
        {
            List<int> TernaryIntegerDigitsToCheck = new List<int>();
            ArrayList TernaryNumbersWithTwo2sInThem = new ArrayList();
            string parsedTargetTernaryNumber = String.Empty;
            
            foreach (var integer in integerRangeMembers)
            {
                TernaryIntegerDigitsToCheck = ConvertIntegerRangeMemberToTernary(integer);
                
                for (int i = 0; i < TernaryIntegerDigitsToCheck.Count; i++)
                {
                    int digitsTwoCounter = 0;

                    while (digitsTwoCounter < 2)
                    {
                        if (TernaryIntegerDigitsToCheck[i] == 2)
                        {
                            digitsTwoCounter++;
                        }    
                    }
                    if (digitsTwoCounter >= 2)
                    {
                        parsedTargetTernaryNumber = string.Join("", TernaryIntegerDigitsToCheck.ToArray());
                    }
                }
                TernaryNumbersWithTwo2sInThem.Add(parsedTargetTernaryNumber);
            }
            return TernaryNumbersWithTwo2sInThem;
        }
    }
}