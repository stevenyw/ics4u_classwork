using System;

class Testing {
    public static string PairStar(string str) {
        if (str.Length < 2) {
            return str;
        }
        if (str[0] == str[1]) {
            return str[0] + "*" + str[1] + PairStar(str.Substring(2));
        }
        return str[0] + PairStar(str.Substring(1));
    }
}

class Program
{
    public static void Main(string[] args)
    {
        string Test = Testing.PairStar("hello");
        Console.WriteLine(Test);
    }
}
