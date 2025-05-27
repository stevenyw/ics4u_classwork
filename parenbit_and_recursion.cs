// Given a string that contains a single pair of parenthesis, compute recursively a new string made of only of the parenthesis and their contents, so "xyz(abc)123" yields "(abc)".

using System;

class Testing {
    public static string ParenBit(string str) {
        if (str[0] != '(') { // Single quotation marks mean string
            return ParenBit(str.Substring(1));
        }
        if (str[0] != ')') {
            return ParenBit(str.Substring(1));
        }
        return str;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Try programiz.pro");
    }
}
