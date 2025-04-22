// Given a string, compute recursively a new string where all the adjacent chars are now separated by a "*".
// allStar("hello") → "h*e*l*l*o"   

using System;

class Testing {
    public static string AllStar(string str) {
        if (str.Length == 0) {
            return str;
        }
        return str[0] + "*" + AllStar(str.Substring(1)); // Adds the first character + star + rest, over and over
    }
}

class Program
{
    public static void Main(string[] args)
    {
        string thing = Testing.AllStar("apple");
        Console.WriteLine(thing);
    }
}
