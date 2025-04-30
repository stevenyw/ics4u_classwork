// Given a string, return recursively a "cleaned" string where adjacent chars that are the same have been reduced to a single char. So "yyzzza" yields "yza".
// stringClean("yyzzza") → "yza"

using System;

class Testing {
    public static string StringClean(string str) {
        if (str.Length == 0 || str.Length == 1) {
            return str;
        }
        
        if (str[0] == str[1]) {
            return StringClean(str.Substring(1));
        }
        return str[0] + StringClean(str.Substring(1));
    }
}

class Program
{
    public static void Main(string[] args)
    {
        string thing = Testing.StringClean("yyyxxa");
        Console.WriteLine(thing);
    }
}
