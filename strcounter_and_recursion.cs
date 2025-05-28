using System;

class Testing {
    public static bool StrCopies(string str, string prompt, int counter) {
        if (str.Length < prompt.Length) {
            return (counter<=0);
        }
        if (str.Substring(0, prompt.Length) == prompt) {
            return StrCopies(str.Substring(prompt.Length), prompt, counter-1);
        }
        return StrCopies(str.Substring(1), prompt, counter);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Try programiz.pro");
    }
}
