using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWarsC.Challenges
{
    /*
    Challenge made by riston
    The main idea is to count all the occuring characters(UTF-8) in string. If you have
    string like this aba then the result should be { 'a': 2, 'b': 1 }
    What if the string is empty ? Then the result should be empty object literal { }
    For C#: Use a Dictionary<char, int> for this kata!
    git testline remowe it after
    Dictionary<char,int> result = CountCharacters
        .Count1("aba");
        foreach(KeyValuePair<char,int> d in result)
        {
            Console.WriteLine(d);
        }
    */
    class CountCharacters
    {
        //first dirty impelementation
        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach(char c in str)
            {
                if(charCount.ContainsKey(c))
                {
                    charCount[c]++;
                } else
                {
                    charCount.Add(c, 1);
                }
            }

            return charCount;
        }
        //with linq
        public static Dictionary<char, int> Count1(string str)
        {
            return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        }
    }
}
