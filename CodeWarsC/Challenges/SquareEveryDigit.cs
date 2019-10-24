using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsC.Challenges
{
    /* Made by MysteriousMagenta
    Welcome. In this kata, you are asked to square every digit of a number.
    For example, if we run 9119 through the function, 811181 will come out,
     because 9^2 is 81 and 1^2 is 1.
    Note: The function accepts an integer and returns an integer
    
    int result = SquareEveryDigit.SquareDigits(9119);
    
     */
    class SquareEveryDigit 
    {
    //first dirty implementation
    public static int SquareDigits(int n)
  {
    string param = n.ToString();
    StringBuilder resultString = new StringBuilder("");
    
    foreach(char s in param) {
        double num = (int) int.Parse(s.ToString());
        num *= num;
        resultString.Append(num.ToString());
    }
    return (int) double.Parse(resultString.ToString());
  }
    }
}
