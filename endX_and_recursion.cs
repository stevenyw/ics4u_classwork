// Given a string, compute recursively a new string where all the lowercase 'x' chars have been moved to the end of the string.
// endX("xxre") → "rexx"

using System;

class Testing {
    public static string EndX(string str) {
        if (str.Length == 0) {
            return str;
        }
        if (str.Substring(0, 1) == "x") {
            return EndX(str.Substring(1, str.Length-1)) + str[0];
        }
        return str[0] + EndX(str.Substring(1));
    }
}

class Program
{
    public static void Main(string[] args)
    {
        string test = Testing.EndX("xxre");
        Console.WriteLine(test);
        }
}
