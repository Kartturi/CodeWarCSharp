using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWarsC.Challenges
{
    /* Made by MysteriousMagenta
    Take 2 strings s1 and s2 including only letters from ato z. Return a new sorted string, the longest possible, containing distinct letters,

    each taken only once - coming from s1 or s2.
    Examples:
    a = "xyaabbbccccdefww"
    b = "xxxxyyyyabklmopq"
    longest(a, b) -> "abcdefklmopqwxy"

    a = "abcdefghijklmnopqrstuvwxyz"
    longest(a, a) -> "abcdefghijklmnopqrstuvwxyz"
    
    string result = TwoToOne.Longest("xyaabbbccccdefww", "xxxxyyyyabklmopq");
    System.Console.WriteLine(result);
     */
    class TwoToOne 
    {
        //First dirty implementation, O(n);
        public static string Longest (string s1, string s2) 
        {
        IDictionary<char, int> charsA = new Dictionary<char, int>(); 
        StringBuilder resulA = new StringBuilder("");


        foreach(char s in s1 + s2) {
            if(!charsA.ContainsKey(s)) {
                charsA.Add(s,1);
                resulA.Append(s.ToString());
            } 
        }
        char[] a = resulA.ToString().ToCharArray();
        Array.Sort(a);
        return new string(a);

        }

        //second implementation
        public static string Longest2(string s1, string s2) {
            return new string((s1+s2).Distinct().OrderBy(x => x).ToArray());
        }
    }
}
