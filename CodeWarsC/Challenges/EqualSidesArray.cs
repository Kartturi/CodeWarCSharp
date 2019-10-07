

using System;

namespace codeWarC.Challenges
{

    /*  Challenge made by Shivo
        You are going to be given an array of integers. 
        Your job is to take that array and find an index 
        N where the sum of the integers to the left of N is 
        equal to the sum of the integers to the right of N.
        If there is no index that would make this happen, return -1.
     */
  public  class EqualSideArrays
    {
        //first dirty implementatiton, O(n2)
        /*public static int FindEvenIndex(int[] arr)
        {
            int leftSum = 0;
            for(int i = 0; i < arr.Length; i++) {
                //calculate leftsum
                int rightSum = 0;
                if(i == 0) {
                    leftSum = 0;
                
                } else {
                    leftSum += arr[i - 1];
                }

                for(int j = i + 1; j < arr.Length; j++) {
                    rightSum += arr[j];
                }
                if(leftSum == rightSum) {
                       return i;
                    }
            }
            return -1;
        }*/

        //method 2, O(n)
        public static int FindEvenIndex(int[] arr) {
            int index = -1;
            int rightSum = 0;
            int leftSum = 0;

            foreach(int value in arr) {
                rightSum += value;
            }

            for(int i = 0; i < arr.Length; i++) {
                index++;
                rightSum -= arr[index];

                if(leftSum == rightSum) {
                    return index;
                }
                leftSum += arr[index];
            }

            return -1;
        }
    }
}