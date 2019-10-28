using System;
using System.Collections.Generic;
using CodeWarsC.Challenges;
namespace CodeWarsC.Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = ValidParentheses.Parentheses1("(())");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
