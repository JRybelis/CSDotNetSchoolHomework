using System;
using System.Collections.Generic;
using System.Linq;

namespace ISBN10ControlDigitGenerator
{
    public class CalculateCheckDigit
    {
        public string FindTheISBNControlDigit(List<string> userProvidedISBNWithoutControlDigit)
        {
            List<int> firstNineISBNDigits
                = userProvidedISBNWithoutControlDigit.Select(int.Parse).ToList();
            var nineDigitWeightedSum = 0;

           for (int i = 10; i > 1; i--)
           {
               int digit = firstNineISBNDigits[10 - i];
               int weightedDigit = digit * i;
               nineDigitWeightedSum += weightedDigit;
           }
           
           var remainder = nineDigitWeightedSum % 11;

           string controlDigit = (11 - remainder).ToString();
           if (controlDigit == "10")
           {
               controlDigit = "X";
           }

           return controlDigit;
        }
    }
}