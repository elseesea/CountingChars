using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CountingChars
{
    class CharCounter
    {
        public static void CountChars(string stringToCount, Dictionary<char, int> charsCounts)
        {
            string alphaOnlyString = Regex.Replace(stringToCount, "[^A-Za-z]", ""); //ignore non-alpha characters
            char[] charactersInString = alphaOnlyString.ToCharArray();
            foreach(char aChar in charactersInString)
            {
                char lowerChar = Char.ToLower(aChar);
                if (charsCounts.ContainsKey(lowerChar)) // case insensitive
                {
                    charsCounts[lowerChar]++;
                } else {
                    charsCounts.Add(lowerChar, 1);
                }
            }

        }

        public static void PrintCharsCounts(Dictionary<char, int> charsCounts)
        {
            foreach(KeyValuePair<char, int> aKeyValuePair in charsCounts)
            {
                Console.WriteLine(aKeyValuePair.Key + ": " + aKeyValuePair.Value);
            }
        }
    }
}
