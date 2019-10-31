using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsC.Challenges
{

    /*
    Everyone knows passphrases. One can choose passphrases from poems, songs, movies names 
    and so on but frequently they can be guessed due to common cultural references. You can
    get your passphrases stronger by different means. One is the following:
    choose a text in capital letters including or not digits and non alphabetic characters,
    shift each letter by a given number but the transformed letter must be a letter (circular shift),
    replace each digit by its complement to 9,
    keep such as non alphabetic and non digit characters,
    downcase each letter in odd position, upcase each letter in even position (the first character is in position 0),
    reverse the whole result.
    #Example:
    your text: "BORN IN 2015!", shift 1
    1 + 2 + 3 -> "CPSO JO 7984!"
    4 "CpSo jO 7984!"
    5 "!4897 Oj oSpC"
    With longer passphrases it's better to have a small and easy program. Would you write it?
    https://en.wikipedia.org/wiki/Passphrase
     */
    class Passphrases
    {
        public static string playPass(string s, int n)
        {
            //phase 1, replace letter by numb
            char[] phase1 = s.ToLower().ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                char curr = phase1[i];
                int ascii = (int)curr;
                if (ascii > 96 && ascii < 123)
                {
                    int newAscii = ascii + n;
                    if (newAscii >= 122)
                    {
                        phase1[i] = Convert.ToChar(97 + (newAscii - 122));
                        continue;
                    } 
                    phase1[i] = Convert.ToChar(ascii);
                }
            }
            Console.WriteLine("asd");
            return "";
        }

        
    }
}
