using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsC.Challenges
{
    /*
            Made by JustyFY    
            Given a list lst and a number N, create a new list that contains 
            each number of lst at most N times without reordering. 
            For example if N = 2, and the input is [1,2,3,1,2,1,2,3],
            you take [1,2,3,1,2], drop the next [1,2] since this would lead 
            to 1 and 2 being in the result 3 times, 
            and then take 3, which leads to [1,2,3,1,2,3].

            put this to main method to test it 
            int[] results = DeleteOccurences.DeleteNth(new int[] { 1, 2, 3, 1,2,5}, 1);
            foreach(int i in results)
            {
                Console.WriteLine(i);
            }
         */
    public class DeleteOccurences
    {
        //method 1. first dirty implementation, O(n2)
        /*public static int?[] DeleteNth(int?[] arr, int x)
        {       
            List<int?> resultList = new List<int?>();
            for (int i = 0; i < arr.Length; i++)
            {
                int counter = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                    }
                    if (arr[i] == arr[j] && counter >= x)
                    {
                        arr[j] = null;
                    } 
                }
               }
            foreach (int? i in arr)
            {
                if(i != null)
                {
                    resultList.Add(i);
                }
            }

            
            return resultList.ToArray();
        }*/

            //method 2, O(n);
        public static int[] DeleteNth(int[] arr, int x)
        {
            Dictionary<int, int> occurence = new Dictionary<int, int>();
            List<int> resultList = new List<int>();

            foreach(int i in arr)
            {
                //check if exists in dict, if not then add it
                   if(!occurence.ContainsKey(i))
                {
                    occurence.Add(i, 1);
                } else
                {
                    
                    occurence[i]++;
                }
                //else increase counter in dict
                    if(occurence[i] <= x)
                {
                    resultList.Add(i);
                }
                //check if i is lower than x, if yes add i to resultList
            //
            }
            return resultList.ToArray();
        }
    }

    
   
}
