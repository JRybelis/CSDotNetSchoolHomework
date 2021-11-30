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
            var dividend = integerRangeMember;
            const int divisor = 3;
            var quotient = dividend / divisor;
            var remainder = dividend % divisor;
            List<int> ternaryIntegerDigits = new();
            
            ternaryIntegerDigits.Add(remainder);
            while (quotient != 0)
            {
                remainder = quotient % divisor;
                ternaryIntegerDigits.Add(remainder);
                quotient /= divisor;
            }
            

            ternaryIntegerDigits.Reverse();

            return ternaryIntegerDigits;
        }

        public static ArrayList CheckTernaryIntegersForTwo2S(int[] integerRangeMembers) // is the param really needed?
        {
            List<int> ternaryIntegerDigitsToCheck = new List<int>();
            ArrayList ternaryNumbersWithTwo2SInThem = new ArrayList();
            string parsedTargetTernaryNumber = String.Empty;
            
            foreach (var integer in integerRangeMembers) // todo split into two methods? a) find the 2 twos b) collect these into an arrayList 
            {
                ternaryIntegerDigitsToCheck = ConvertIntegerRangeMemberToTernary(integer);
                
                for (int i = 0; i < ternaryIntegerDigitsToCheck.Count; i++)
                {
                    int digitsTwoCounter = 0;

                    while (digitsTwoCounter < 2)
                    {
                        if (ternaryIntegerDigitsToCheck[i] == 2)//todo fix infinite loop
                        {
                            digitsTwoCounter++;
                        }    
                    }
                    if (digitsTwoCounter >= 2)
                    {
                        parsedTargetTernaryNumber = string.Join("", ternaryIntegerDigitsToCheck.ToArray());
                    }
                }
                ternaryNumbersWithTwo2SInThem.Add(parsedTargetTernaryNumber);
            }
            return ternaryNumbersWithTwo2SInThem;
        }
    }
}