

using System;
using System.Linq;

namespace CodeWarsC.Challenges
{

    /*  Challenge made by wichu
        Your task is to write function findSum.
        Upto and including n, this function will return the sum of all multiples of 3 and 5.
        For example:
        findSum(5) should return 8 (3 + 5)
        findSum(10) should return 33 (3 + 5 + 6 + 9 + 10)

     */
  public static class SumMul35
    {
      //first dirty implementation
      public static int findSum(int n)
        {
        int result = 0;
        for(int i = 0; i<=n; i++) {
          if(i % 3 == 0 || i % 5 == 0) {
            result += i;
          }
        }
        return result;
        }
        public static int findSum2(int n) {
          return Enumerable.Range(1, n).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
        }
        
    }
}