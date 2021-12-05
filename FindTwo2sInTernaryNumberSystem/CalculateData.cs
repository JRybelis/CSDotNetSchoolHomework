using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FindTwo2sInTernaryNumberSystem
{
    public class CalculateData
    {
        public int[] FindIntegerRangeMembers(int firstInteger, int lastInteger)
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

        public List<int> ConvertIntegerRangeMemberToTernary(int integerRangeMember)
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

        public string CheckTernaryIntegerForTwo2S(List<int> ternaryIntegerDigitsToCheck)
        {
            string parsedTargetTernaryNumber = string.Empty;
            var digitsTwoCounter = 0;
            foreach (var ternaryIntegerDigit in ternaryIntegerDigitsToCheck) 
            {
                if (ternaryIntegerDigit == 2)
                {
                    digitsTwoCounter++;
                }
                if (digitsTwoCounter >= 2)
                {
                    parsedTargetTernaryNumber = string.Join("", ternaryIntegerDigitsToCheck.ToArray());
                }
            }
            return parsedTargetTernaryNumber;
        }

        public ArrayList CollectTernariesWithTwo2S(IEnumerable<int> integerRangeMembers)
        {
            ArrayList ternaryNumbersWithTwo2SInThem = new ArrayList();

            foreach (var integer in integerRangeMembers)
            {
                List<int> ternaryIntegerDigitsToCheck = ConvertIntegerRangeMemberToTernary(integer);
                string parsedTargetTernaryNumber = CheckTernaryIntegerForTwo2S(ternaryIntegerDigitsToCheck);

                if (parsedTargetTernaryNumber != "")
                {
                    ternaryNumbersWithTwo2SInThem.Add(parsedTargetTernaryNumber);    
                }
            }
            return ternaryNumbersWithTwo2SInThem;
        }
            
    }
}
