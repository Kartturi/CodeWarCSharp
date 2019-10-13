using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsC.Challenges
{
    /* Made by MysteriousMagenta
     Welcome.In this kata you are required to, given a string, replace every letter with its position in the alphabet.
    If anything in the text isn't a letter, ignore it and don't return it.
    "a" = 1, "b" = 2, etc.
    Example
    Kata.AlphabetPosition("The sunset sets at twelve o' clock.")
    Should return "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11" (as a string)
     */
    class ReplaceAlphabetPosition
    {
        //first dirty impelmentation, O(n)
        public static string AlphabetPosition(string text)
        {
            List<string> resultList = new List<string>();
            foreach (char c in text)
            {
                int asciiLowest = 96;
                int asciiHighest = 123;
                
                char lowerStr = char.ToLower(c);
                int letterNum = (int)lowerStr;
                if(letterNum > asciiLowest && letterNum < asciiHighest)
                {
                    int subtracted = letterNum - asciiLowest;
                    resultList.Add(subtracted.ToString());
                }
            }
            
            var result = String.Join(" ", resultList.ToArray());
                return result;
        }
    }
}
