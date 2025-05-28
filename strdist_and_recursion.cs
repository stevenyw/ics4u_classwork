using System;

class Testing {
    public static int StrDist(string str, string prompt) {
        if (str.Length < prompt.Length) {
            return 0;
        }
        if (str.StartsWith(prompt) && str.EndsWith(prompt)) {
            return str.Length;
        }
        if (!str.StartsWith(prompt)) {
            return StrDist(str.Substring(1), prompt);
        }
        return StrDist(str.Substring(0, str.Length-1), prompt);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Testing.StrDist("meoeeowmeoewmefartcatcatxx", "cat"));
    }
}
