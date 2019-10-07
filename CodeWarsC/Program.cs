using System;
using CodeWarsC.Challenges;
namespace CodeWarsC
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] results = DeleteOccurences.DeleteNth(new int[] { 1, 2, 3, 1,2,5}, 1);

            foreach(int i in results)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
