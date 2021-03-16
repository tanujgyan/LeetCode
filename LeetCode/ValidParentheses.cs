using System.Collections.Generic;

public class ValidParentheses
{
    /// <summary>
    /// When you get a starting paranthesis push it to stack and when getting an ending paranthesis pop from stack and compare. 
    /// If comparison passes continue else return false and end it
    /// At the end of the string stack should be empty. Return true
    /// If it is not then return false
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public bool CheckIfValidParentheses(string s)
    {
        Stack<char> startparanthesis = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                startparanthesis.Push(c);
            }
            else
            {
                if(startparanthesis.Count==0 || (startparanthesis.Count>0 && c != ReturnOppositeParanthesis(startparanthesis.Pop())))
                {
                    return false;
                }
            }
        }
        if (startparanthesis.Count == 0)
            return true;
        else
            return false;
    }
    public char ReturnOppositeParanthesis(char c)
    {
        if (c == '(') return ')';
        else if (c == '[') return ']';
        else if (c == '{') return '}';
        return new char();
    }
}