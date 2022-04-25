using System;

namespace RomanToInteger
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            var inputCharArray = s.ToCharArray();
            int returnMe = 0;

            for (int i = 0; i < inputCharArray.Length; i++)
            {
                int currentValue = 0;
                int comparisonValue = 0;
                var currentChar = inputCharArray[i];
                currentValue = returnIntFromRomanNumeral(currentChar);
                if (i + 1 == inputCharArray.Length)
                {
                    returnMe += currentValue;
                    continue;
                }
                var nextChar = inputCharArray[i + 1];
                comparisonValue = returnIntFromRomanNumeral(nextChar);
                if (currentValue < comparisonValue)
                {
                    returnMe += comparisonValue - currentValue;
                    i++;
                }
                else
                {
                    returnMe += currentValue;
                }



            }
            Console.WriteLine(returnMe);
            return returnMe;
        }

        private static int returnIntFromRomanNumeral(char currentChar)
        {
            switch (currentChar)
            {
                case 'I':
                    return 1;

                case 'V':
                    return 5;

                case 'X':
                    return 10;

                case 'L':
                    return 50;

                case 'C':
                    return 100;

                case 'D':
                    return 500;

                case 'M':
                    return 1000;

            }
            throw new NotImplementedException();
        }
    }
}
