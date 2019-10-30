using System;
using System.Collections.Generic;
using CodeWarsC.Challenges;
namespace CodeWarsC.Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = GoodVsEvil.Battle("1 1 1 1 1 1", "1 1 1 1 1 1 1");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
