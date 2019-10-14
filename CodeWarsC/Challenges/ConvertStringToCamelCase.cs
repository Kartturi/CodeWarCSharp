using System;
using System.Collections.Generic;

namespace CodeWarsC.Challenges {
    /*Challenge made by Jhoffner
    Complete the method/function so that it converts dash/underscore delimited words into camel casing. The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case).
    Examples
    Kata.ToCamelCase("the-stealth-warrior") // returns "theStealthWarrior"
    Kata.ToCamelCase("The_Stealth_Warrior") // returns "TheStealthWarrior
     */
public class CamelCaseString
{
  public static string ToCamelCase(string str)
  {
    string[] stringArr = new []{str};
    List<string> resultList = new List<string>();
    foreach(string s in stringArr) {
        System.Console.WriteLine(s);
    }
    for(int i = 0; i < str.Length - 1; i++) {
        
        // if(stringArr[i] == "-" || stringArr[i] == "_") {
        //     System.Console.WriteLine(stringArr[i]);
        //     // string nextChar = stringArr[i + 1];
        //     // stringArr[i + 1] = nextChar.ToUpper();
        // } 
    }
    // foreach(string s in resultList) {
    //     System.Console.WriteLine(s);
    // }
    
    return "asd";
  }
}
}