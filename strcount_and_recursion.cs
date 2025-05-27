using System;

class Testing {
    public static int StrCount(string thing, string prompt) {
        if (thing.Length < prompt.Length) {
            return 0;
        }
        if (thing.Substring(0, prompt.Length) == prompt) {
            return 1 + StrCount(thing.Substring(prompt.Length), prompt);
        } else {a
            return StrCount(thing.Substring(1), prompt);
        }
    }
}

class Program {
    public static void Main(string[] args) {
       Console.WriteLine(Testing.StrCount("catcowcat", "cat")); // → 2
    }
}
