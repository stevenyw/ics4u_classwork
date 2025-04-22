// Given a string, compute recursively (no loops) a new string where all appearances of "pi" have been replaced by "3.14".
// changePi("xpix") → "x3.14x";

using System;

class Testing {
    public static string ChangePi(string str) {
        if (str.Length < 2) {
            return str;
        }
        if (str.Substring(0, 2) == "pi") {
            return "3.14" + ChangePi(str.Substring(2));
        }
        return str[0] + ChangePi(str.Substring(1));
    }
}

class Program
{
    public static void Main(string[] args)
    {
        string piemaker = Testing.ChangePi("xpipix");
        Console.WriteLine(piemaker);
    }
}
