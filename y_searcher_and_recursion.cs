// Given a string, compute recursively (no loops) a new string where all the lowercase 'x' chars have been changed to 'y' chars.

// changeXY("codex") → "codey"
// changeXY("xxhixx") → "yyhiyy"

using System;

class Testing {
    public static string ChangeXY(string str) {
        if (str.Length == 0) {
            return str; 
        }
        if (str.Substring(0, 1) == "x") {
            return "y" + ChangeXY(str.Substring(1));
        }
        return str[0] + ChangeXY(str.Substring(1));
    }
}

class Program
{
    public static void Main(string[] args)
    {
        string thing = Testing.ChangeXY("xxKillerShadowxx");
        Console.WriteLine(thing);
    }
}
