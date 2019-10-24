using System;
using System.Collections.Generic;
using System.Text;

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
    
     */
    class TwoToOne 
    {
        //First dirty implementation, O(n);
        public static string Longest (string s1, string s2) 
        {
        IDictionary<char, int> charsA = new Dictionary<char, int>(); 
        IDictionary<char, int> charsB = new Dictionary<char, int>(); 
        StringBuilder resulA = new StringBuilder("");
        StringBuilder resulB = new StringBuilder("");


        foreach(char s in s1) {
            if(!charsA.ContainsKey(s)) {
                charsA.Add(s,1);
                resulA.Append(s.ToString());
            } 
        }
        foreach(char s in s2) {
            if(!charsB.ContainsKey(s)) {
                charsB.Add(s,1);
                resulB.Append(s.ToString());
            } 
        }
        ;
        char[] a = resulA.ToString().ToCharArray();
        char[] b = resulB.ToString().ToCharArray();

        Array.Sort(a);
        Array.Sort(b);

        char[] resultArr = a.Length > b.Length ? a : b;
        return new string(resultArr);

        }
    }
}
