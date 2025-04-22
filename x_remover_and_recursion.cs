// Given a string, compute recursively a new string where all the 'x' chars have been removed.
// noX("xaxb") → "ab"

using System;

class Testing {
    public static string NoX(string str) {
        if (str.Length == 0) {
            return str;
        }
        if (str.Substring(0, 1) == "x") {
            return NoX(str.Substring(1));
        }
        return str[0] + NoX(str.Substring(1));
    }
}

class Program
{
    public static void Main(string[] args)
    {
        string blah = Testing.NoX("xabx");
        Console.WriteLine(blah);
    }
}
