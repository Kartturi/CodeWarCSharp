using System;
using System.Collections.Generic;
using CodeWarsC.Challenges;
namespace CodeWarsC.Challenges
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<char,int> result = CountCharacters
            .Count1("aba");
            foreach(KeyValuePair<char,int> d in result)
            {
                Console.WriteLine(d);
                
            }
            Console.ReadLine();
        }
    }
}
