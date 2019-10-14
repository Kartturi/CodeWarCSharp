using System;

namespace CodeWarsC.Challenges {
    /*
Your task is to write a function which returns the sum of following series 
upto nth term(parameter).
Series: 1 + 1/4 + 1/7 + 1/10 + 1/13 + 1/16 +...
Rules:
You need to round the answer to 2 decimal places and return it as String.

If the given value is 0 then it should return 0.00

You will only be given Natural Numbers as arguments.

Examples:
SeriesSum(1) => 1 = "1.00"
SeriesSum(2) => 1 + 1/4 = "1.25"
SeriesSum(5) => 1 + 1/4 + 1/7 + 1/10 + 1/13 = "1.57"

put following code to main method
string result = NthSeries.seriesSum(5);
System.Console.WriteLine(result);

     */
//first dirty implementation, o(N)
public class NthSeries {
	
	public static string seriesSum (int n) {
		double init = 1;
        int initDelimeter = 1;
        int delimeter = 4;

        for(int i = 1; i < n; i++) {
            init += (double) initDelimeter/delimeter;
            delimeter += 3;
        }
        double rounded = Math.Round(init,2);
        return rounded.ToString("0.00");
	}
}
}