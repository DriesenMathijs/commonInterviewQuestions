using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public static class Palindrome
    {
        public static string CheckAndGivePalindrome(string input)
        {
            string palindrome = null;
            input = input.ToLower();

            var charArr = input.ToCharArray();
            Array.Reverse(charArr);

            palindrome = new string(charArr);

            if (!input.Equals(palindrome))
            {
                return null;
            }

            return palindrome;
        }

        public static bool IsPalindromeSingleLine(string input)
        {
            return input.SequenceEqual(input.ToLower().Reverse());
        }

        //Should be shorter...
        public static string LongestPalindrome(string testingString)
        {
            int stringLength = testingString.Length;
            int maxPalindromeStringLength = 0;
            int maxPalindromeStringStartIndex = 0;
            for (int i = 0; i < stringLength; i++)
            {
                int currentCharIndex = i;
                for (int lastCharIndex = stringLength - 1; lastCharIndex > currentCharIndex; lastCharIndex--)
                {
                    if (lastCharIndex - currentCharIndex + 1 < maxPalindromeStringLength)
                    {
                        break;
                    }
                    bool isPalindrome = true;
                    if (testingString[currentCharIndex] != testingString[lastCharIndex])
                    {
                        continue;
                    }
                    else
                    {
                        int matchedCharIndexFromEnd = lastCharIndex - 1;
                        for (int nextCharIndex = currentCharIndex + 1; nextCharIndex < matchedCharIndexFromEnd; nextCharIndex++)
                        {
                            if (testingString[nextCharIndex] != testingString[matchedCharIndexFromEnd])
                            {
                                isPalindrome = false;
                                break;
                            }
                            matchedCharIndexFromEnd--;
                        }
                    }
                    if (isPalindrome)
                    {
                        if (lastCharIndex + 1 - currentCharIndex > maxPalindromeStringLength)
                        {
                            maxPalindromeStringStartIndex = currentCharIndex;
                            maxPalindromeStringLength = lastCharIndex + 1 - currentCharIndex;
                        }
                        break;
                    }
                }
            }
            if (maxPalindromeStringLength > 0)
            {
                return testingString.Substring(maxPalindromeStringStartIndex, maxPalindromeStringLength);
            }
            return null;
        }

        public static string LongestPalindromeSh(string input)
        {
            return null;
        }
    }
}
