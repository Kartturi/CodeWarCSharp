using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsC.Challenges
{
    /*Made by xDranik
    Write a function called that takes a string of parentheses, and determines if the order of the parentheses is valid. The function should return true if the string is valid, and false if it's invalid.
    Examples
    "()"              =>  true
    ")(()))"          =>  false
    "("               =>  false
    "(())((()())())"  =>  true
    Constraints
    0 <= input.length <= 100

    Along with opening (() and closing ()) parenthesis, input may contain any valid ASCII characters.
    Furthermore, the input string may be empty and/or not contain any parentheses at all. Do not treat other 
    forms of brackets as parentheses (e.g. [], {}, <>).
     */
    class ValidParentheses
    {
        //first dirty implementation
        public static bool Parentheses(string input)
        {
            Stack<char> bracketStack = new Stack<char>();
            foreach(char c in input)
            {
                if(c.Equals('('))
                {
                    bracketStack.Push(')');
                }
                else if (c.Equals(')'))
                {
                    try
                    {
                        if (!c.Equals(bracketStack.Peek()))
                        {
                            return false;
                        }
                    } catch(Exception e)
                    {
                        Console.WriteLine(e);
                        return false;
                    }
                    bracketStack.Pop();
                }
            }
            return bracketStack.Count == 0 ? true : false;
        }
        //improved version
        public static bool Parentheses1(string input)
        {
            int counter = 0;
            foreach(char p in input)
            {
                if(p == '(')
                {
                    counter++;
                } else if(p == ')')
                {
                    counter--;
                }
            }

            return counter == 0;
        }
    }
}
